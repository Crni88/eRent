using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.NekretninaKorisnik
{
    public class NekretninaKorisnikService
        : BaseCRUDService<NekretninaKorisnikModel, DataDB.NekretninaKorisnik, NekretninaKorisnikSearchObject, NekretninaKorisnikUpsertRequest, NekretninaKorisnikUpsertRequest>, INekretninaKorisnikService
    {
        public NekretninaKorisnikService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override IQueryable<DataDB.NekretninaKorisnik> AddFilter(IQueryable<DataDB.NekretninaKorisnik> query, NekretninaKorisnikSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Nekretnina == search.NekretninaId);
            }
            return filteredQuery;
        }
    }
}
