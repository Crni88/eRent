﻿using eRent.Services;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        public IService<T> Service { get; set; }

        public BaseController(IService<T> service)
        {
            Service = service;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return Service.Get();
        }
    }
}
