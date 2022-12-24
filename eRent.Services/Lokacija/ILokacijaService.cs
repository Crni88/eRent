using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;

namespace eRent.Services.Lokacija
{
    public interface ILokacijaService : ICRUDService<LokacijaModel, LokacijaSearchObject, LokacijaUpsertRequest, LokacijaUpsertRequest>
    {


    }
}
