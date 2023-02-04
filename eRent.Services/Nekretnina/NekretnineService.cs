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
            entity.Drzava = Context.Lokacijas.Where(x => x.LokacijaId == insert.LokacijaId).Select(x => x.Drzava).FirstOrDefault();
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
            return filteredQuery;
        }
    }
}
