using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T t);
        T Update(T t);
        void Delete(int id);
    }
}
