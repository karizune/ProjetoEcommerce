using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    class RepositoryBase
    {
    }
}
using ProjetoEcommerce.Dominio.Interfaces.Base;
using ProjetoEcommerce.Data.EntityFramework.Context;
using System.Data.Entity;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class RepositoryBase<TObject> : IRepositoryBase<TObject> where TObject : class
    {
        private readonly ProjetoEcommerceContext _context;
        protected readonly DbSet<TObject> Entity;

        public RepositoryBase()
        {
            _context = new ProjetoEcommerceContext();
            Entity = _context.Set<TObject>();

        }
        public TObject Add(TObject t)
        {
            Entity.Add(t);
            _context.SaveChanges();
            return t;
        }

        public void Delete(TObject t)
        {
            Entity.Remove(t);
            _context.SaveChanges();
        }

        public TObject GetOne(int id)
        {
            return Entity.Find(id);
        }

        public TObject Update(TObject t)
        {
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return t;
        }
    }
}
