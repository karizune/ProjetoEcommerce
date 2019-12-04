using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class RepositoryBase<TObject> : IRepositoryBase<TObject> where TObject : class
    {
        private ProjetoEcommerceContext _context = new ProjetoEcommerceContext();

        protected DbSet<TObject> Entity { get; set; }

        public RepositoryBase()
        {
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
