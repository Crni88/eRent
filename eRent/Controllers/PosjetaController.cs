using eRent.Models;
using eRent.Models.Requests.Posjeta;
using eRent.Models.Search_Objects;
using eRent.Services.Posjeta;

namespace eRent.Controllers
{
    public class PosjetaController : BaseCRUDController<PosjetaModel, PosjetaSearchObject, PosjetaInsertRequest, PosjetaUpdateRequest>
    {
        public PosjetaController(IPosjetaService posjetaService) : base(posjetaService)
        {
        }
    }
}
