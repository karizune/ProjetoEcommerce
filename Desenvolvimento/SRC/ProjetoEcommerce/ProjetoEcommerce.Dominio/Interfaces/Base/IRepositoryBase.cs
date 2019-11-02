using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Base
{
    public interface IRepositoryBase<TObject> where TObject:class
    {
        TObject GetOne(int id);
        TObject Add(TObject t);
        TObject Update(TObject t);
        void Delete(TObject t);

    }
}
