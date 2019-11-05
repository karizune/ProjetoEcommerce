using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class CepsService : ICepsService
    {
        private readonly CepsRepository _repository;
        public CepsService()
        {
            _repository = new CepsRepository();
        }
        public Ceps Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Ceps> GetAll()
        {
            return _repository.GetAll();
        }

        public Ceps GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Ceps Save(Ceps obj)
        {
            return _repository.Save(obj);
        }

        public Ceps Update(Ceps obj)
        {
            return _repository.Update(obj);
        }
    }
}
