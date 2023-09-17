using eRent.Models;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Search_Objects;

namespace eRent.Services.FitPasos
{
    public interface IFitPasosService : ICRUDService<FitPasosModel, FitPasosSearchObject, FitPasosInsertRequest, FitPasosUpdateRequest>
    {
    }
}
