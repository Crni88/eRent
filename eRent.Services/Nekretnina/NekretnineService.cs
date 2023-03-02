using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace eRent.Services.Nekretnina
{
    public class NekretnineService
        : BaseCRUDService<NekretninaModel, DataDB.Nekretnina, NekretninaSearchObject, NekretninaInsertRequest, NekretninaUpdateRequest>, INekretnineService
    {
        public ERentContext context { get; set; }

        public NekretnineService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
            context = eRentContext;
        }

        public override NekretninaModel Insert(NekretninaInsertRequest insert)
        {
            //if (insert.NazivNekretnine == "string")
            //{
            //    throw new UserException("Error occured.");
            //}
            var entity = base.Insert(insert);
            foreach (var tagId in insert.TagIdList)
            {
                DataDB.NekretninaTagovi nekretninaTagovi = new DataDB.NekretninaTagovi();
                nekretninaTagovi.NekretninaId = entity.NekretninaId;
                nekretninaTagovi.TagId = tagId;
                Context.NekretninaTagovis.Add(nekretninaTagovi);
            }
            //entity.Drzava = Context.Lokacijas.Where(x => x.LokacijaId == insert.LokacijaId).Select(x => x.Drzava).FirstOrDefault();
            Context.SaveChanges();
            return entity;
        }
        public override IQueryable<DataDB.Nekretnina> AddFilter(IQueryable<DataDB.Nekretnina> query, NekretninaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.NekretninaId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaId == search.NekretninaId);
            }
            if (!string.IsNullOrWhiteSpace(search?.NazivNekretnine))
            {
                filteredQuery = filteredQuery.Where(x => x.NazivNekretnine.StartsWith(search.NazivNekretnine));
            }
            if (!string.IsNullOrEmpty(search?.NameFTS))
            {
                filteredQuery = filteredQuery.Where(x => x.NazivNekretnine.Contains(search.NameFTS));
            }
            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.Username == search.Username);
            }
            if (search?.BrojSoba != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.BrojSoba >= search.BrojSoba);
            }
            if (search?.CijenaMin != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.Cijena >= search.CijenaMin);
            }
            if (search.CijenaMax != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.Cijena <= search.CijenaMax);
            }
            return filteredQuery;
        }

        private const double V = 0.00001;
        static object isLocked = new object();
        static MLContext mlContext = null;
        static ITransformer model = null;
        public List<NekretninaModel> Recommend(int id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    // Retrieve all properties with their associated tags
                    var properties = context.Nekretninas
                        .Include(p => p.NekretninaTagovis)
                        .ToList();

                    // Retrieve all customers with their associated tags
                    var customers = context.Korisniks
                        .Include(c => c.KorisnikTagovis)
                        .ToList();

                    var data = new List<PropertyEntry>();

                    // For each property, create a CoPurchaseProductID entry for each other property that shares at least one tag
                    foreach (var p1 in properties)
                    {
                        foreach (var p2 in properties.Where(p => p.NekretninaId != p1.NekretninaId))
                        {
                            if (p1.NekretninaTagovis.Any(t1 => p2.NekretninaTagovis.Any(t2 => t2.TagId == t1.TagId)))
                            {
                                data.Add(new PropertyEntry()
                                {
                                    PropertyID = (uint)p1.NekretninaId,
                                    CoPurchasePropertyID = (uint)p2.NekretninaId,
                                });
                            }
                        }
                    }

                    // For each customer, create a CoPurchaseProductID entry for each property that shares at least one tag
                    foreach (var c in customers)
                    {
                        foreach (var p in properties)
                        {
                            if (c.KorisnikTagovis.Any(t1 => p.NekretninaTagovis.Any(t2 => t2.TagId == t1.TagId)))
                            {
                                data.Add(new PropertyEntry()
                                {
                                    PropertyID = (uint)p.NekretninaId,
                                    CoPurchasePropertyID = (uint)c.KorisnikId,
                                });
                            }
                        }
                    }
                    
                    var traindata = mlContext.Data.LoadFromEnumerable(data);

                    // STEP 3: Specify options for MatrixFactorizationTrainer with a few extra hyperparameters
                    var options = new MatrixFactorizationTrainer.Options()
                    {
                        MatrixColumnIndexColumnName = nameof(PropertyEntry.PropertyID),
                        MatrixRowIndexColumnName = nameof(PropertyEntry.CoPurchasePropertyID),
                        LabelColumnName = "Label",
                        LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                        Alpha = 0.01,
                        Lambda = 0.025,
                        // For better results use the following parameters
                        NumberOfIterations = 100,
                        C = V
                    };
                    // STEP 4: Train the Matrix Factorization model
                    MatrixFactorizationTrainer trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                    ITransformer model = trainer.Fit(traindata);

                    var allProperties = context.Nekretninas.Where(x => x.NekretninaId != id);
                    var predictionResult = new List<Tuple<DataDB.Nekretnina,float>>();
                    foreach (var property in allProperties)
                    {
                        var predictionEngine = mlContext.Model.CreatePredictionEngine<PropertyEntry, CoPurchase_prediction>(model);
                        var prediction = predictionEngine.Predict(new PropertyEntry() { 
                            PropertyID = (uint)id,
                            CoPurchasePropertyID=(uint)property.NekretninaId
                        }) ;
                        predictionResult.Add(new Tuple<DataDB.Nekretnina, float>(property,prediction.Score));
                    }
                    var finalResult = predictionResult.OrderByDescending(x=>x.Item2).Select(x=>x.Item1).Take(3).ToList();

                    return Mapper.Map<List<NekretninaModel>>(finalResult);
                }
            }
            return new List<NekretninaModel>();
        }
    }
}

public class PropertyEntry
{
    [KeyType(count: 5000)]
    public uint PropertyID { get; set; }

    [KeyType(count: 5000)]
    public uint CoPurchasePropertyID { get; set; }
    public float Label { get; set; }
}

public class CoPurchase_prediction
{
    public float Score { get; set; }
}

