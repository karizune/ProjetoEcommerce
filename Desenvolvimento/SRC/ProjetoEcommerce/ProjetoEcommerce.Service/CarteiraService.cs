using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;


namespace ProjetoEcommerce.Service
{
    public class CarteiraService : ICarteiraService
    {
        ICarteiraRepository _repository = new CarteiraRepository();
        public void Add(Carteira obj)
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

        public Carteira Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Carteira> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Carteira obj)
        {
            obj.Usuario = "Sistema";
            obj.AtualizadoEm = DateTime.Now;
            _repository.Update(obj);
        }
    }
}
