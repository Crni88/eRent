using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Posjeta;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Posjeta
{
    public class PosjetaService
        : BaseCRUDService<PosjetaModel, DataDB.Posjetum, PosjetaSearchObject, PosjetaInsertRequest, PosjetaUpdateRequest>, IPosjetaService
    {
        public PosjetaService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override void BeforeInsert(PosjetaInsertRequest insert, DataDB.Posjetum entity)
        {
            entity.NazivNekretnine =
                Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaId).Select(x => x.NazivNekretnine).FirstOrDefault();

            var prezime =
                 Context.Korisniks.Where(x => x.KorisnikId == insert.KorisnikId).Select(x => x.KorisnikPrezime).FirstOrDefault();
            var ime =
             Context.Korisniks.Where(x => x.KorisnikId == insert.KorisnikId).Select(x => x.KorsnikIme).FirstOrDefault();

            entity.KorisnikImePrezime =
                ime + " " + prezime;

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<DataDB.Posjetum> AddFilter(IQueryable<DataDB.Posjetum> query, PosjetaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search?.NekretninaId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaId == search.NekretninaId);
            }
            if (search?.KorisnikId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            }
            if (search?.Otkazana != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Otkazana == search.Otkazana);
            }
            return filteredQuery;
        }
    }
}


