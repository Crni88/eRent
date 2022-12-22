using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.Services.Uloge;

namespace eRent.Controllers
{
    public class UlogeController : BaseController<UlogaModel, BaseSearchObject>
    {

        public UlogeController(IUlogeService ulogeService) : base(ulogeService)
        {
        }
    }
}
