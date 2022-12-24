using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;

namespace eRent.Services.Nekretnina
{
    public interface INekretnineService : ICRUDService<NekretninaModel, NekretninaSearchObject, NekretninaUpsertRequest, NekretninaUpsertRequest>
    {

    }
}
