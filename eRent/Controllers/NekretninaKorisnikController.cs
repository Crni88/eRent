using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Search_Objects;
using eRent.Services;
using eRent.Services.Lokacija;
using eRent.Services.NekretninaKorisnik;

namespace eRent.Controllers
{
    public class NekretninaKorisnikController : BaseCRUDController<NekretninaKorisnikModel, NekretninaKorisnikSearchObject, NekretninaKorisnikUpsertRequest, NekretninaKorisnikUpsertRequest>
    {
        public NekretninaKorisnikController(INekretninaKorisnikService nekretninaKorisnikService) : base(nekretninaKorisnikService)
        {
        }
    }
}   
