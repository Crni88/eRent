using eRent.Models;
using eRent.Services.DataDB;
using eRent.Services.Uloge;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eRent.Controllers
{
    public class UlogeController : BaseController<UlogaModel>
    {

        public UlogeController(IUlogeService ulogeService):base(ulogeService)
        {
        }
    }
}
