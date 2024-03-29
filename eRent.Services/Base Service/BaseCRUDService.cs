﻿using AutoMapper;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public virtual T Insert(TInsert insert)
        {
            var set = Context.Set<TDb>();
            TDb entity = Mapper.Map<TDb>(insert);
            set.Add(entity);
            BeforeInsert(insert, entity);
            Context.SaveChanges();
            return Mapper.Map<T>(entity);
        }

        public virtual void BeforeInsert(TInsert insert, TDb entity)
        {

        }


        public virtual T Update(int id, TUpdate update)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            if (entity != null)
            {
                Mapper.Map(update, entity);
            }
            else
            {
                return null;
            }
            Context.SaveChanges();
            return Mapper.Map<T>(entity);
        }
    }
}
