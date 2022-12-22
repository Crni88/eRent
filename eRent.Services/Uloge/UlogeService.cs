using AutoMapper;
using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Uloge
{
    public class UlogeService : BaseService<UlogaModel, Uloga, BaseSearchObject>, IUlogeService
    {
        public UlogeService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
    }
}