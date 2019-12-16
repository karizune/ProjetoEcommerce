using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(T t);
        void Delete(int id);
    }
}
