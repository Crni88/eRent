using AutoMapper;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch>
        where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public ERentContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public BaseService(ERentContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<TDb>().AsQueryable();
            entity = AddFilter(entity, search);
            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entity = entity.Take(search.PageSize.Value).Skip(search.Page.Value);
            }
            var list = entity.ToList();

            return Mapper.Map<IEnumerable<T>>(list);
        }

        public T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return Mapper.Map<T>(entity);
        }


        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> dbs, TSearch search = null)
        {
            return dbs;
        }
    }
}
