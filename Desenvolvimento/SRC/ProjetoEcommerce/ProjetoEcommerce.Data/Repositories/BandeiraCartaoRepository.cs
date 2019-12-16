using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class BandeiraCartaoRepository : IBandeiraCartaoRespository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();

        public void Add(BandeiraCartao t)
        {
            _context.Set<BandeiraCartao>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<BandeiraCartao>().Remove(ent);
            _context.SaveChanges();
        }

        public BandeiraCartao Get(int id)
        {
            return _context.Set<BandeiraCartao>().FirstOrDefault(f=>f.BandeiraCartaoID == id);
        }

        public IEnumerable<BandeiraCartao> GetAll()
        {
            return _context.Set<BandeiraCartao>();
        }

        public void Update(BandeiraCartao t)
        {
            _context.Set<BandeiraCartao>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
           
        }
    }
}
