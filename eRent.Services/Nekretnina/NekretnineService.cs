using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Nekretnina
{
    public class NekretnineService
        : BaseCRUDService<NekretninaModel, DataDB.Nekretnina, NekretninaSearchObject, NekretninaUpsertRequest, NekretninaUpsertRequest>, INekretnineService
    {
        public NekretnineService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override IQueryable<DataDB.Nekretnina> AddFilter(IQueryable<DataDB.Nekretnina> query, NekretninaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.NazivNekretnine))
            {
                filteredQuery = filteredQuery.Where(x => x.NazivNekretnine.StartsWith(search.NazivNekretnine));
            }
            return filteredQuery;
        }
    }
}
