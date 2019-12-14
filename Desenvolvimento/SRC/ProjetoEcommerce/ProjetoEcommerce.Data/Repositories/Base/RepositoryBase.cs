using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoEcommerce.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoEcommerceContext Db = new ProjetoEcommerceContext();
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>()
                .AsNoTracking()
                .ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetManyBy(Expression<Func<TEntity, bool>> match)
        {
            return Db.Set<TEntity>().Where(match);
        }

        public TEntity GetOneBy(Expression<Func<TEntity, bool>> match)
        {
            return Db.Set<TEntity>().Where(match).FirstOrDefault();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Set<TEntity>().AddOrUpdate(obj);
            Db.SaveChanges();
        }

    }
}
