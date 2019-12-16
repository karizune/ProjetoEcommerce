using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service
{
    public class Cartao_TipoService : ICartao_TipoService
    {
        ICartao_TipoRepository _repository = new Cartao_TipoRepository();
        public void Add(Cartao_Tipo obj)
        {
            obj.Status = 1;
            obj.Usuario = "Sistema";
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;
            _repository.Add(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
            
        }

        public void Delete(int CartaoID, int TipoCartaoID)
        {
            var ent = Get(CartaoID,TipoCartaoID);
            ent.Status = ent.Status == 0 ? 1 : 0;
            Update(ent);
        }

        public Cartao_Tipo Get(int id)
        {
            throw new NotImplementedException();
        }

        public Cartao_Tipo Get(int CartaoID, int TipoCartaoID)
        {
            return _repository.Get(CartaoID, TipoCartaoID);
        }
        public IEnumerable<Cartao_Tipo> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Cartao_Tipo obj)
        {
            obj.Usuario = "Sistema";
            obj.AtualizadoEm = DateTime.Now;
            _repository.Update(obj);
        }
    }
}
