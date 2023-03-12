using eRent.Models;
using eRent.Models.Requests.NekretninaTag;

namespace eRent.Services.NekretninaTagovi
{
    public interface INekretninaTagovi : 
        ICRUDService<NekretninaTagoviModel,NekretninaTagoviSearchObject,NekretninaTagoviInsertRequest, NekretninaTagUpdateRequest>
    {
    }
}
