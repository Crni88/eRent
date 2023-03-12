using eRent.Models;
using eRent.Models.Requests.NekretninaTag;
using eRent.Services.NekretninaTagovi;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class NekretnineTagoviController : BaseCRUDController<NekretninaTagoviModel, NekretninaTagoviSearchObject, NekretninaTagoviInsertRequest, NekretninaTagUpdateRequest>
    {
        public NekretnineTagoviController(INekretninaTagovi nekretninaTagoviService) : base(nekretninaTagoviService)
        {
          
        }

        [HttpGet("TagsByProperty")]
        public NekretninaTagoviModel GetByPropId(int id)
        {
            return Service.Test(id);
        }
    }
}
