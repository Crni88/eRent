using AutoMapper;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services
{
    public class BaseCRUDService<T, TDb, TSearch,TInsert,TUpdate> : BaseService<T, TDb, TSearch> , ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class where TDb : class where TSearch  : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(ERentContext eRentContext,IMapper mapper):base(eRentContext,mapper)
        {
        }


        public T Insert(TInsert insert)
        {
            var set = Context.Set<TDb>();
            TDb entity = Mapper.Map<TDb>(insert);
            set.Add(entity);
            Context.SaveChanges();
            return Mapper.Map<T>(entity);
        }

        public T Update(int id, TUpdate update)
        {
            throw new NotImplementedException();
        }
    }
}
