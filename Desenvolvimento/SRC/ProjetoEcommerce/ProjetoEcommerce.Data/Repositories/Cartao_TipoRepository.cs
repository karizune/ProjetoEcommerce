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
    public class Cartao_TipoRepository : ICartao_TipoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(Cartao_Tipo t)
        {
            _context.Set<Cartao_Tipo>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
           
        }

        public void Delete(int CartaoID, int TipoCartaoID)
        {
            var ent = Get(CartaoID,TipoCartaoID);
            _context.Set<Cartao_Tipo>().Remove(ent);
            _context.SaveChanges();
        }

        public Cartao_Tipo Get(int CartaoID,int TipoCartaoID)
        {
            return _context.Set<Cartao_Tipo>().Find(CartaoID,TipoCartaoID);
        }

        public Cartao_Tipo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cartao_Tipo> GetAll()
        {
            return _context.Set<Cartao_Tipo>();
        }

        public void Update(Cartao_Tipo t)
        {
            _context.Set<Cartao_Tipo>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
