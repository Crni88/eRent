using eRent.Models;
using eRent.Models.Requests.Rejting;
using eRent.Models.Search_Objects;
using eRent.Services.Rejting;

namespace eRent.Controllers
{
    public class RejtingController : BaseCRUDController<RejtingModel, RejtingSearchObject, RejtingInsertRequest, RejtingUpdateRequest>
    {
        public RejtingController(IRejtingService service) : base(service)
        {
        }
    }
}
