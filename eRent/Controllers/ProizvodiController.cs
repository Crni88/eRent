using eRent.Services.Testni;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {

        private readonly iProizvodiService _proizvodiService;

        public ProizvodiController(iProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public IEnumerable<Proizvodi> Get()
        {
            return _proizvodiService.Get();
        }
    }
}
