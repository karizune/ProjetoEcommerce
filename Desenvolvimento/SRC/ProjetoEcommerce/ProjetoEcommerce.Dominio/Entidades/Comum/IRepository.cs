using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Comum
{
    public interface IRepository<T> where T : class
    {
        T Save(T obj);

        T Update(T obj);

        T Delete(int id, string usuario);

        T GetOne(int id);

        IEnumerable<T> GetAll();
    }
}
