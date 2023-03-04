using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;

namespace eRent.Services.Ugovor
{
    public interface IUgovorService : ICRUDService<UgovorModel, BaseSearchObject, UgovorUpsertRequest, UgovorUpsertRequest>
    {
    }
}
