using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetOneBy(Expression<Func<TEntity, bool>> match);
        IEnumerable<TEntity> GetManyBy(Expression<Func<TEntity, bool>> match);
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();


        void Remove(TEntity obj);
        void Update(TEntity obj);
        void Dispose();
    }
}
