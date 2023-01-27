using eRent.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> Service { get; set; }

        public BaseController(IService<T, TSearch> service)
        {
            Service = service;
        }

        //Add GetById 

        [HttpGet]
        public IEnumerable<T> Get([FromQuery] TSearch search = null)
        {
            return Service.Get(search);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return Service.GetById(id); 
        }
    }
}
