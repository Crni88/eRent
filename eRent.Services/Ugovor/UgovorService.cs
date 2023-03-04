using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Ugovor
{
    public class UgovorService
       : BaseCRUDService<UgovorModel, DataDB.Ugovor, BaseSearchObject, UgovorUpsertRequest, UgovorUpsertRequest>, IUgovorService
    {
        public UgovorService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        public override void BeforeInsert(UgovorUpsertRequest insert, DataDB.Ugovor entity)
        {
            entity.Nekretnina = 
                Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaId).Select(x => x.NazivNekretnine).FirstOrDefault();
            entity.UgovornaStranka = Context.Korisniks.Where(x => x.KorisnikId == insert.PodnosiocUgovoraId).Select(x => x.KorsnikIme).FirstOrDefault();
            entity.UgovornaStranka += Context.Korisniks.Where(x => x.KorisnikId == insert.PodnosiocUgovoraId).Select(x => x.KorisnikPrezime).FirstOrDefault();
            base.BeforeInsert(insert, entity);
        }
    }
}
