using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Search_Objects;

namespace eRent.Services.NekretninaKorisnik
{
    public interface INekretninaKorisnikService : ICRUDService<NekretninaKorisnikModel, 
        NekretninaKorisnikSearchObject, NekretninaKorisnikUpsertRequest, NekretninaKorisnikUpsertRequest>
    {

    }
}