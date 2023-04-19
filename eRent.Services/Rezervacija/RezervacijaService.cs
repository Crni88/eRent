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
            if (search != null)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaId == search.NekretninaId);
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
    }
}