using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Korisnici
{
    public class KorisniciService
        : BaseCRUDService<KorisnikModel, Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>, IKorisniciService
    {
        public KorisniciService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        //public override IEnumerable<KorisnikModel> Get(KorisnikSearchObject korisnikSearchObject = null)
        //{
        //    return base.Get(korisnikSearchObject);
        //}
        public override IQueryable<Korisnik> AddFilter(IQueryable<Korisnik> query, KorisnikSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (!string.IsNullOrEmpty(search?.Email))
            {
                filteredQuery = filteredQuery.Where(x => x.Email == search.Email);
            }
            if (!string.IsNullOrEmpty(search?.KorsnikIme))
            {
                filteredQuery = filteredQuery.Where(x => x.KorsnikIme == search.KorsnikIme);
            }

            if (!string.IsNullOrEmpty(search?.KorsnikPrezime))
            {
                filteredQuery = filteredQuery.Where(x => x.KorsnikIme == search.KorsnikPrezime);
            }

            //if (search.Page.HasValue)
            //{
            //    //filteredQuery = filteredQuery.Take(search.Page.Value).Skip(search.PageSize.Value);
            //}
            return filteredQuery;
        }
    }
}
