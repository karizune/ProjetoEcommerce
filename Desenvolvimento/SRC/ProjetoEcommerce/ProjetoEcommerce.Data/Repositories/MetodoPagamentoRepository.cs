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
   public class MetodoPagamentoRepository : IMetodoPagamentoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(MetodoPagamento t)
        {
            _context.Set<MetodoPagamento>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<MetodoPagamento>().Remove(ent);
            _context.SaveChanges();
        }

        public MetodoPagamento Get(int id)
        {
            return _context.Set<MetodoPagamento>().FirstOrDefault(f => f.MetodoPagamentoID == id);
        }

        public IEnumerable<MetodoPagamento> GetAll()
        {
            return _context.Set<MetodoPagamento>();
        }

        public void Update(MetodoPagamento t)
        {
            _context.Set<MetodoPagamento>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
