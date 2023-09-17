using AutoMapper;
using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.FitPasos
{
    public class FitPasosService : BaseCRUDService<Models.FitPasosModel, FitPaso, Models.Search_Objects.FitPasosSearchObject, Models.Requests.FitPasos.FitPasosInsertRequest, Models.Requests.FitPasos.FitPasosUpdateRequest>, IFitPasosService
    {
        public FitPasosService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override IQueryable<FitPaso> AddFilter(IQueryable<FitPaso> dbs, FitPasosSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(dbs, search);
            if (search?.PasosId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.PasosId == search.PasosId);
            }
            if (search?.KorisnikId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if (search?.IsValid != null)
            {
                filteredQuery = filteredQuery.Where(x => x.IsValid == search.IsValid);
            }
            if (search?.DatumIsteka != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumIsteka <= search.DatumIsteka);
            }
            if (search?.DatumIzdavanja != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumIzdavanja >= search.DatumIzdavanja);
            }
            return filteredQuery;
        }

        public override IEnumerable<FitPasosModel> Get(FitPasosSearchObject search = null)
        {
            var updatedPasosi = base.Get(search)
               .Where(pasos => pasos.PasosId != 0)
               .Join(Context.Korisniks,
               pasosi => pasosi.KorisnikId,
               korisnik => korisnik.KorisnikId,
               (pasosi, korisnik) =>
               {
                   pasosi.Korisnik = Mapper.Map<KorisnikModel>(korisnik);
                   return pasosi;
               });

            return updatedPasosi;
        }
    }
}
