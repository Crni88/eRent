using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;
using eRent.Services.Korisnici;

namespace eRent.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class KorisniciController : BaseCRUDController<KorisnikModel, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        public KorisniciController(IKorisniciService korisniciServis) : base(korisniciServis)
        {
        }
    }
}
