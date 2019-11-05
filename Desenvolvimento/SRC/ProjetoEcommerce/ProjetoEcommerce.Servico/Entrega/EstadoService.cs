using ProjetoEcommerce.Data.EntityFramework.Context;
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
    public class EstadoService : IEstadoService
    {
        private readonly EstadoRepository _repository;
        public EstadoService()
        {
            _repository = new EstadoRepository();
        }
        public Estado Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Estado> GetAll()
        {
            return _repository.GetAll();
        }

        public Estado GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Estado Save(Estado obj)
        {
            return _repository.Save(obj);
        }

        public Estado Update(Estado obj)
        {
            return _repository.Update(obj);
        }
    }
}
