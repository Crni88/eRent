﻿using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.Services.Uloge;

namespace eRent.Controllers
{
    public class UlogeController : BaseCRUDController<UlogaModel, UlogaSearchObject>
    {

        public UlogeController(IUlogeService ulogeService) : base(ulogeService)
        {
        }
    }
}
