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
    public class TipoCartaoRepository : ITipoCartaoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(TipoCartao t)
        {
            _context.Set<TipoCartao>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<TipoCartao>().Remove(ent);
            _context.SaveChanges();
        }

        public TipoCartao Get(int id)
        {
            return _context.Set<TipoCartao>().FirstOrDefault(f => f.TipoCartaoID == id);
        }

        public IEnumerable<TipoCartao> GetAll()
        {
            return _context.Set<TipoCartao>();
        }

        public void Update(TipoCartao t)
        {
            _context.Set<TipoCartao>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

    }
}

