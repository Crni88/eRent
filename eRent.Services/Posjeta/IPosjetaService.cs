using eRent.Models;
using eRent.Models.Requests.Posjeta;
using eRent.Models.Search_Objects;

namespace eRent.Services.Posjeta
{
    public interface IPosjetaService : ICRUDService<PosjetaModel, PosjetaSearchObject, PosjetaInsertRequest, PosjetaUpdateRequest>
    {
    }
}
