using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service.Interfaces
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public TEntity Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
            return obj;
        }

        public TEntity GetOneBy(Expression<Func<TEntity, bool>> match)
        {
            return _repositoryBase.GetOneBy(match);
        }

        public IEnumerable<TEntity> GetManyBy(Expression<Func<TEntity, bool>> match)
        {
            return _repositoryBase.GetManyBy(match);
        }

        public TEntity Update(TEntity obj)
        {
            return _repositoryBase.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

    }
}