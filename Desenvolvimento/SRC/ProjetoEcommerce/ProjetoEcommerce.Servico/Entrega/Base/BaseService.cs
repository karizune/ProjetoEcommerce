using ProjetoEcommerce.Data.EntityFramework.Repository;
using ProjetoEcommerce.Dominio.Entidades.Entrega.Interfaces;
using System.Collections.Generic;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly BaseRepository<T> _repository;

        public BaseService()
        {
            _repository = new BaseRepository<T>();
        }

        public T Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public T Save(T obj)
        {
            return _repository.Save(obj);
        }

        public T Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}