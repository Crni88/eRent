using eRent.Models;
using eRent.Models.Requests.Rejting;
using eRent.Models.Search_Objects;

namespace eRent.Services.Rejting
{
    public interface IRejtingService : ICRUDService<RejtingModel, RejtingSearchObject, RejtingInsertRequest, RejtingUpdateRequest>
    {
    }
}
