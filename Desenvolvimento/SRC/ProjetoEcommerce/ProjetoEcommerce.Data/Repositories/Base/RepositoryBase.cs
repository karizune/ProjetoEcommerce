using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Interfaces.Base;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class RepositoryBase<TObject> : IRepositoryBase<TObject> where TObject : class
    {

        private ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public TObject Add(TObject t)
        {
            _context.Set<TObject>().Add(t);
            _context.SaveChanges();
            return t;
        }

        public void Delete(TObject t)
        {
            _context.Set<TObject>().Remove(t);
            _context.SaveChanges();
        }

        public TObject GetOne(int id)
        {
            return _context.Set<TObject>().Find(id);
        }

        public TObject Update(TObject t)
        {
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return t;
        }
    }
    {
    }
}
