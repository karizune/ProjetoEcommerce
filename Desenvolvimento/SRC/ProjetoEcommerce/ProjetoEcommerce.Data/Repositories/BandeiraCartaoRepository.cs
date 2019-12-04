using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class BandeiraCartaoRepository : IBandeiraCartaoRespository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();

        public BandeiraCartao Add(BandeiraCartao t)
        {
            return _context.Set<BandeiraCartao>().Add(t);
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<BandeiraCartao>().Remove(ent);
        }

        public BandeiraCartao Get(int id)
        {
            return _context.Set<BandeiraCartao>().Find(id);
        }

        public IEnumerable<BandeiraCartao> GetAll()
        {
            return _context.Set<BandeiraCartao>();
        }

        public BandeiraCartao Update(BandeiraCartao t)
        {
            var ent = _context.Set<BandeiraCartao>().Attach(t);
            _context.SaveChanges();
            return ent;
        }
    }
}
