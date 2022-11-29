using eRent.Model;
using eRent.Services;
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
        public IEnumerable<Korisnik> Get()
        {
            return _korisniciServis.Get();
        }
    }
}
