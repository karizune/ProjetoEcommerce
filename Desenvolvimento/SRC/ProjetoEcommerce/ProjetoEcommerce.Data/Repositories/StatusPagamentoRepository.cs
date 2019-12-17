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
    public class StatusPagamentoRepository: IStatusPagamentoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(StatusPagamento t)
        {
            _context.Set<StatusPagamento>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<StatusPagamento>().Remove(ent);
            _context.SaveChanges();
        }

        public StatusPagamento Get(int id)
        {
            return _context.Set<StatusPagamento>().FirstOrDefault(f => f.StatusPagamentoID == id);
        }

        public IEnumerable<StatusPagamento> GetAll()
        {
            return _context.Set<StatusPagamento>();
        }

        public void Update(StatusPagamento t)
        {
            _context.Set<StatusPagamento>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
