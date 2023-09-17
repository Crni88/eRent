using eRent.Models;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Search_Objects;

namespace eRent.Services.FITPasos
{
    public interface IFITPasos : 
        ICRUDService<FitPasosModel, FitPasosSearchObject, FITPasosInsertRequest, FitPasosUpdateRequest>
    {
    }
}
