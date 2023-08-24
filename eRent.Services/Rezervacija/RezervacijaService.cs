using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Rezervacija
{
    public class RezervacijaService : BaseCRUDService<RezervacijaModel, DataDB.Rezervacija, RezervacijaSearchObject, RezervacijaInsertRequest, RezervacijaUpdateRequest>, IRezervacijaService
    {
        public RezervacijaService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        public override IQueryable<DataDB.Rezervacija> AddFilter(IQueryable<DataDB.Rezervacija> query, RezervacijaSearchObject search = null)
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
            if (search?.DatumKraja != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumKraja.Value <= search.DatumKraja.Value);
            }
            if (search?.DatumPocetka != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DatumPocetka.Value >= search.DatumPocetka.Value);
            }
            if (search?.Odobrena != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Odobrena == search.Odobrena);
            }
            if (search?.Odbijena != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Odbijena == search.Odbijena);
            }
            return filteredQuery;
        }

        public override void BeforeInsert(RezervacijaInsertRequest insert, DataDB.Rezervacija entity)
        {
            entity.Nazivnekretnine =
                Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaId).Select(x => x.NazivNekretnine).FirstOrDefault();
            entity.Odobrena = false;
            base.BeforeInsert(insert, entity);
        }

        public override IEnumerable<RezervacijaModel> Get(RezervacijaSearchObject search = null)
        {
            var rezervacije = base.Get(search); // Get the list of reservations from the base method

            var nekretninaIds = rezervacije
                .Where(r => r.NekretninaId != 0)
                .Select(r => r.NekretninaId)
                .Distinct()
                .ToList();

            var nekretnine = Context.Nekretninas
                .Where(n => nekretninaIds.Contains(n.NekretninaId))
                .ToList();

            var nekretnineDictionary = nekretnine.ToDictionary(n => n.NekretninaId);

            foreach (var rezervacija in rezervacije)
            {
                if (rezervacija.NekretninaId != 0 && nekretnineDictionary.TryGetValue(rezervacija.NekretninaId, out var nekretnina))
                {
                    rezervacija.Nekretnina = Mapper.Map<NekretninaModel>(nekretnina);
                }
            }
            return rezervacije;
        }
    }
}