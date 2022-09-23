using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T,bool>> expression);
        
        void add(T entity);
        void addrange(IEnumerable<T> entities);
       
        void Update(T entity);
        void RemoveRange(IEnumerable<T> entities);
        bool Exists(Expression<Func<T, bool>> expression);
        void remove(T entity);
        void Save();
        
    }
}
