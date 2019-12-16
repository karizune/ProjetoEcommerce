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
    class CartaoRepository : ICartaoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(Cartao t)
        {
            _context.Set<Cartao>().Add(t);
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<Cartao>().Remove(ent);
        }

        public Cartao Get(int id)
        {
           return _context.Set<Cartao>().First(f => f.CartaoID == id);
        }

        public IEnumerable<Cartao> GetAll()
        {
            return _context.Set<Cartao>();
        }

        public void Update(Cartao t)
        {
            _context.Set<Cartao>().Attach(t);
            _context.SaveChanges();
            
        }
    }
}
