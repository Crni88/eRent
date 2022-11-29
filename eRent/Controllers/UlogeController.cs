using eRent.Services.DataDB;
using eRent.Services.Uloge;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eRent.Controllers
{
    [ApiController]
    [Route("api/uloge")]
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _ulogeService;

        public UlogeController(IUlogeService ulogeService)
        {
            _ulogeService = ulogeService;
        }

        [HttpGet]
        public IEnumerable<Uloga> Get()
        {
            return _ulogeService.Get();
        }

        [HttpPost]
        public IEnumerable<Uloga> Post(Uloga uloga)
        {
            return _ulogeService.Post(uloga);
        }
    }
}
