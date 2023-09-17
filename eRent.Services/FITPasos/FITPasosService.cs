using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.FITPasos
{
    public class FITPasosService
        : BaseCRUDService<FitPasosModel, DataDB.Fitpaso, FitPasosSearchObject, FITPasosInsertRequest, FitPasosUpdateRequest>, 
        IFITPasos
    {
        public FITPasosService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override IQueryable<DataDB.Fitpaso> AddFilter(IQueryable<DataDB.Fitpaso> query, FitPasosSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != 0 && search.KorisnikId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if (search.PasosId != 0 && search.PasosId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.PasosId == search.PasosId);
            }
            if (search.IsValid != null)
            {
                filteredQuery = filteredQuery.Where(x => x.IsValid == search.IsValid);
            }
            if (search.DatumIzdavanja != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumIzdavanja == search.DatumIzdavanja);
            }

            return filteredQuery;
        }

        public override IEnumerable<FitPasosModel> Get(FitPasosSearchObject search = null)
        {
            var updatedPasosi = base.Get(search)
                .Where(pasos => pasos.KorisnikId != 0)
                .Join(Context.Korisniks,
                      pasos => pasos.KorisnikId,
                      korisnik => korisnik.KorisnikId,
                      (pasos, korisnik) =>
                      {
                          pasos.Korisnik = Mapper.Map<KorisnikModel>(korisnik);
                          return pasos;
                      });

            return updatedPasosi;
        }
    }
}
