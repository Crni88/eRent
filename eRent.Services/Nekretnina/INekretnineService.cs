using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;

namespace eRent.Services.Nekretnina
{
    //Karakteristican set operacija koje se mogu izvršiti na datom skupu entiteta 
    //Specifikacija ponasanja servisa
    //Servisi koji se nude kao metode ili operacije navedene kao prototipovi
    public interface INekretnineService : ICRUDService<NekretninaModel, NekretninaSearchObject, NekretninaInsertRequest, NekretninaUpdateRequest>
    {
        List<NekretninaModel> Recommend(int id);
    }
}
