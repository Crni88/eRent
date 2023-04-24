using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.KorisnikTag;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.KorisnikTagovi
{
    public class KorisnikTagoviService :
                BaseCRUDService<KorisnikTagoviModel, DataDB.KorisnikTagovi, KorisnikTagoviSearchObject, KorisnikTagUpsertRequest, KorisnikTagUpsertRequest>, IKorisnikTagoviService
    {
        public KorisnikTagoviService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
            Context = eRentContext;
        }

        public ERentContext Context { get; set; }


        public override IQueryable<DataDB.KorisnikTagovi> AddFilter(IQueryable<DataDB.KorisnikTagovi> query, KorisnikTagoviSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            }

            return filteredQuery;
        }
    }
}
