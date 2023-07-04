using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.Ugovor;

namespace eRent.Controllers
{
    public class UgovorController
        : BaseAdminCRUDController<UgovorModel, BaseSearchObject, UgovorUpsertRequest, UgovorUpsertRequest>
    {
        public UgovorController(IUgovorService service) : base(service)
        {
        }
    }
}
