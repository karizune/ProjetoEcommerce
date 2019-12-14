using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjetoEcommerce.Service.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetOneBy(Expression<Func<TEntity, bool>> match);
        IEnumerable<TEntity> GetManyBy(Expression<Func<TEntity, bool>> match);
        TEntity Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();


    }
}
