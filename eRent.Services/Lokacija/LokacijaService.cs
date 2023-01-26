using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Lokacija;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Lokacija
{
    public class LokacijaService :
        BaseCRUDService<LokacijaModel, DataDB.Lokacija, LokacijaSearchObject, LokacijaUpsertRequest, LokacijaUpsertRequest>,
        ILokacijaService
    {
        public LokacijaService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {

        }

        public override IQueryable<DataDB.Lokacija> AddFilter(IQueryable<DataDB.Lokacija> query, LokacijaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.LokacijaId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.LokacijaId == search.LokacijaId);
            }

            if (!string.IsNullOrWhiteSpace(search?.Adresa))
            {
                filteredQuery = filteredQuery.Where(x => x.Adresa.StartsWith(search.Adresa));
            }
            return filteredQuery;
        }
    }
}
