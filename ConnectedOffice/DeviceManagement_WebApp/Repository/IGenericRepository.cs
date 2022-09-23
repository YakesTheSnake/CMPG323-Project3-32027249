using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<C> where C : class
    {
        C GetById(Guid id);
        IEnumerable<C> GetAll();
        IEnumerable<C> Find(Expression<Func<C,bool>> expression);
        bool Exists(Expression<Func<C,bool>> expression);
        void add(C entity);
        void addrange(IEnumerable<C> entities);
        void Update(C entity);
        void RemoveRange(IEnumerable<C> entities);
        void remove(C entity);
        void Save();
        
    }
}
