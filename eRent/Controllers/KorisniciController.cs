using eRent.Models;
using eRent.Services.DataDB;
using eRent.Services.Korisnici;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class KorisniciController : BaseController<KorisnikModel>
    {
        public KorisniciController(IKorisnici korisniciServis):base(korisniciServis)
        {
        }
    }
}
