using eRent.Models;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;
using eRent.Services;
using eRent.Services.Rezervacija;

namespace eRent.Controllers
{
    public class RezervacijaController : BaseCRUDController<RezervacijaModel, RezervacijaSearchObject, RezervacijaInsertRequest, RezervacijaUpdateRequest>
    {
        public RezervacijaController(IRezervacijaService rezervacijaService) : base(rezervacijaService)
        {
        }
    }
}
