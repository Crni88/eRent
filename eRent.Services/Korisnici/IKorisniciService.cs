using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;

namespace eRent.Services.Korisnici
{
    public interface IKorisniciService : ICRUDService<KorisnikModel,KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    { }
}
