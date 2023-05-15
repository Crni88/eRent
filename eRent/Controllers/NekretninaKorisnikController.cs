using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Search_Objects;
using eRent.Services.NekretninaKorisnik;

namespace eRent.Controllers
{
    public class NekretninaKorisnikController : BaseAdminCRUDController<NekretninaKorisnikModel, NekretninaKorisnikSearchObject, NekretninaKorisnikInsertRequest, NekretninaKorisnikUpdateRequest>
    {
        public NekretninaKorisnikController(INekretninaKorisnikService nekretninaKorisnikService) : base(nekretninaKorisnikService)
        {
        }
    }
}
