using eRent.Models;
using eRent.Models.Requests.KorisnikTag;
using eRent.Models.Requests.NekretninaTag;
using eRent.Models.Search_Objects;
using eRent.Services.KorisnikTagovi;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class KorisnikTagoviController : BaseCRUDController<KorisnikTagoviModel, KorisnikTagoviSearchObject, KorisnikTagUpsertRequest, KorisnikTagUpsertRequest>
    {
        public KorisnikTagoviController(IKorisnikTagoviService nekretninaTagoviService) : base(nekretninaTagoviService)
        {

        }

        [HttpGet("TagsByUser")]
        public KorisnikTagoviModel GetByPropId(int id)
        {
            return Service.Test(id);
        }
    }
}
