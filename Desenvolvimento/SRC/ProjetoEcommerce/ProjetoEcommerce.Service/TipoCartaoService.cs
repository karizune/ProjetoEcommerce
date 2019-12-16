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
    public class TipoCartaoService : ITipoCartaoService
    {
        ITipoCartaoRepository _repository = new TipoCartaoRepository();
        public void Add(TipoCartao obj)
        {
            obj.Status = 1;
            obj.Usuario = "Sistema";
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;
            _repository.Add(obj);
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            ent.Status = ent.Status == 0 ? 1 : 0;
            Update(ent);
        }

        public TipoCartao Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TipoCartao> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TipoCartao obj)
        {
            obj.Usuario = "Sistema";
            obj.AtualizadoEm = DateTime.Now;
            _repository.Update(obj);
        }
    }
}
