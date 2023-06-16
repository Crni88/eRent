using AutoMapper;
using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Uloge
{
    public class UlogeService : BaseService<UlogaModel, Uloga, UlogaSearchObject>, IUlogeService
    {
        public UlogeService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        public override IQueryable<DataDB.Uloga> AddFilter(IQueryable<DataDB.Uloga> query, UlogaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                filteredQuery = filteredQuery.Where(x => x.Naziv == search.Naziv);
            }
            return filteredQuery;
        }
    }
}