using eRent.Models;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Search_Objects;
using eRent.Services.FITPasos;

namespace eRent.Controllers
{
    public class FitPasosController : BaseCRUDController<FitPasosModel, FitPasosSearchObject, FITPasosInsertRequest, FitPasosUpdateRequest>
    {
        public FitPasosController(IFITPasos fitPasosService) : base(fitPasosService)
        {
        }
    }
}
