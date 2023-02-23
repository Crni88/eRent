using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Rejting;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Rejting
{
    public class RejtingService
        : BaseCRUDService<RejtingModel, DataDB.Rejting, RejtingSearchObject, RejtingInsertRequest, RejtingUpdateRequest>, IRejtingService
    {
        public RejtingService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override void BeforeInsert(RejtingInsertRequest insert, DataDB.Rejting entity)
        {
            entity.Nekretnina =
                Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaRejting).Select(x => x.NazivNekretnine).FirstOrDefault();

            entity.ImePrezime
                = Context.Korisniks.Where(x => x.KorisnikId == insert.KorisnikSec).Select(x => x.KorsnikIme).FirstOrDefault();

            //entity.OverallRejting = insertRejting(insert);

            base.BeforeInsert(insert, entity);
        }

            //double insertRejting(RejtingInsertRequest insert)
            //{
            //    var listabrojSvihRejtinga = Context.Rejtings.Where(x => x.KorisnikPrim == insert.KorisnikPrim);
            //    int brojSvihRejtinga = listabrojSvihRejtinga.Count();
            //    double averageRejting = listabrojSvihRejtinga.Average(x => x.Rejting1);
            //    double finalRejting = (averageRejting + insert.Rejting1) / brojSvihRejtinga + 1;
            //    return finalRejting;
            //}

             public override IQueryable<DataDB.Rejting> AddFilter(IQueryable<DataDB.Rejting> query, RejtingSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search != null)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikPrim == search.KorisnikPrim);
            }
            return filteredQuery;
        }
    }
}
