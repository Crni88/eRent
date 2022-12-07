using eRent.Models;
using eRent.Services;
using eRent.Services.DataDB;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    [ApiController]
    [Route("api/korisnik")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisnici _korisniciServis;

        public KorisniciController(IKorisnici korisniciServis)
        {
            _korisniciServis = korisniciServis;
        }
        [HttpGet]
        public IEnumerable<KorisnikModel> Get()
        {
            return _korisniciServis.Get();
        }
    }
}
