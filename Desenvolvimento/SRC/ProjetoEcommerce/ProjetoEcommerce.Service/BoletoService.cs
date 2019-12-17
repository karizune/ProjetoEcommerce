using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Dominio.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoEcommerce.Service
{
    public class BoletoService : IBoletoService
    {
        IBoletoRepository _repository = new BoletoRepository();
        public void Add(Boleto obj)
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

        public Boleto Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Boleto> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Boleto obj)
        {
            obj.Usuario = "Sistema";
            obj.AtualizadoEm = DateTime.Now;
            _repository.Update(obj);
        }
    }
}
