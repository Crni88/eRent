using eRent.Models;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Search_Objects;
using eRent.Services.FitPasos;

namespace eRent.Controllers
{

    public class FitPasosiController : BaseCRUDController<FitPasosModel, FitPasosSearchObject, FitPasosInsertRequest, FitPasosUpdateRequest>
    {
        public FitPasosiController(IFitPasosService service) : base(service)
        {

        }
    }
}
