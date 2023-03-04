using eRent.Models;
using eRent.Models.Requests.KorisnikTag;
using eRent.Models.Search_Objects;

namespace eRent.Services.KorisnikTagovi
{
    public interface IKorisnikTagoviService :
        ICRUDService<KorisnikTagoviModel, KorisnikTagoviSearchObject, KorisnikTagUpsertRequest, KorisnikTagUpsertRequest>
    {
    }
}
