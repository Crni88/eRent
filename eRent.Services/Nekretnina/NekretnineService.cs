using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Nekretnina
{
    public class NekretnineService
        : BaseCRUDService<NekretninaModel, DataDB.Nekretnina, NekretninaSearchObject, NekretninaInsertRequest, NekretninaUpdateRequest>, INekretnineService
    {

        public NekretnineService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        { }
        //TODO Add Nekretnina Image Upload

        public override NekretninaModel Insert(NekretninaInsertRequest insert)
        {
            var entity = base.Insert(insert);
            foreach (var tagId in insert.TagIdList)
            {
                DataDB.NekretninaTagovi nekretninaTagovi = new DataDB.NekretninaTagovi();
                nekretninaTagovi.NekretninaId = entity.NekretninaId;
                nekretninaTagovi.TagId = tagId;
                Context.NekretninaTagovis.Add(nekretninaTagovi);
            }
            entity.Drzava = Context.Lokacijas.Where(x => x.LokacijaId == insert.LokacijaId).Select(x => x.Drzava).FirstOrDefault();
            Context.SaveChanges();
            return entity;
        }

        public override IQueryable<DataDB.Nekretnina> AddFilter(IQueryable<DataDB.Nekretnina> query, NekretninaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            //TODO Add Get Nekretnina By ID
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
            return filteredQuery;
        }
    }
}
