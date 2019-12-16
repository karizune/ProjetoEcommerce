using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories
{
    public class CarteiraRepository : ICarteiraRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(Carteira t)
        {
            _context.Set<Carteira>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<Carteira>().Remove(ent);
            _context.SaveChanges();
        }

        public Carteira Get(int id)
        {
            return _context.Set<Carteira>().FirstOrDefault(f => f.CarteiraID == id);
        }

        public IEnumerable<Carteira> GetAll()
        {
            return _context.Set<Carteira>();
        }

        public void Update(Carteira t)
        {
            _context.Set<Carteira>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
