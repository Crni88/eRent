using eRent.Models;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;

namespace eRent.Services.Rezervacija
{
    public interface IRezervacijaService :
        ICRUDService<RezervacijaModel, RezervacijaSearchObject, RezervacijaInsertRequest, RezervacijaUpdateRequest>
    {

    }
}
