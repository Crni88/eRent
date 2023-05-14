using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;
using eRent.Services.Korisnici;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class KorisniciController : BaseCRUDController<KorisnikModel, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        public KorisniciController(IKorisniciService korisniciServis) : base(korisniciServis)
        {
        }

        //Dodavanje sa authorizacijom
        [Authorize(Roles = "Admin")]
        public override KorisnikModel Insert([FromBody] KorisnikInsertRequest korisnikInsertRequest)
        {
            return base.Insert(korisnikInsertRequest);
        }
    }
}
