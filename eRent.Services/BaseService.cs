using AutoMapper;
using eRent.Services.DataDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class BaseService<T,TDb> : IService<T> where T : class where TDb : class
    {
        public ERentContext Context { get; set; }  
        public IMapper Mapper { get; set; }

        public BaseService(ERentContext context, IMapper mapper)
        {
            Context = context; 
            Mapper = mapper;    
        }
        public IEnumerable<T> Get()
        {
            var entity = Context.Set<TDb>();
            var list  = entity.ToList();
            return Mapper.Map<IEnumerable<T>>(list);    
        }

    }
}
