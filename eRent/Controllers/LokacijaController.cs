using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.Lokacija;

namespace eRent.Controllers
{
    public class LokacijaController : BaseCRUDController<LokacijaModel, LokacijaSearchObject, LokacijaUpsertRequest, LokacijaUpsertRequest>
    {
        public LokacijaController(ILokacijaService lokacijaService) : base(lokacijaService)
        {
        }
    }
}
