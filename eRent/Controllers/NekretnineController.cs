using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.Nekretnina;

namespace eRent.Controllers
{
    public class NekretnineController :
        BaseCRUDController<NekretninaModel, NekretninaSearchObject, NekretninaInsertRequest, NekretninaUpdateRequest>
    {
        public NekretnineController(INekretnineService service) : base(service)
        {
        }
    }
}
