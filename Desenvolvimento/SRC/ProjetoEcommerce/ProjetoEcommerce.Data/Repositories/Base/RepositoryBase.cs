using System.Collections.Generic;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Interfaces.Base;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class RepositoryBase<TObject> : IRepositoryBase<TObject> where TObject : class
    {
        private ProjetoEcommerceContext _context = new ProjetoEcommerceContext();

        public void Add(TObject t)
        {
            _context.Set<TObject>().Add(t);
            _context.SaveChanges();
           
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<TObject>().Remove(ent);
            _context.SaveChanges();
        }

        public TObject Get(int id)
        {
            return _context.Set<TObject>().Find(id);
        }

        public IEnumerable<TObject> GetAll()
        {
            return _context.Set<TObject>();
        }

        public void Update(TObject t)
        {
            _context.Set<TObject>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            
        }
    }
}
