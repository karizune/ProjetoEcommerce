using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Update(T obj);
        void Delete(int id);
        void Add(T obj);
    }
}
