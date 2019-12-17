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
    public class BoletoRepository : IBoletoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(Boleto t)
        {
            _context.Set<Boleto>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<Boleto>().Remove(ent);
            _context.SaveChanges();
        }

        public Boleto Get(int id)
        {
            return _context.Set<Boleto>().FirstOrDefault(f => f.BoletoID == id);
        }

        public IEnumerable<Boleto> GetAll()
        {
            return _context.Set<Boleto>();
        }

        public void Update(Boleto t)
        {
            _context.Set<Boleto>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
