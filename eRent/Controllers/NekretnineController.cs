using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.Nekretnina;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class NekretnineController :
        BaseCRUDController<NekretninaModel, NekretninaSearchObject, NekretninaInsertRequest, NekretninaUpdateRequest>
    {
        public INekretnineService service { get; set; }
        public NekretnineController(INekretnineService service) : base(service)
        {
            this.service = service;
        }
        [HttpGet("{id}/Recommend")]
        public List<NekretninaModel> Recommend(int id)
        {
            var result = service.Recommend(id);
            return result;
        }
    }
}
