using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Base
{
    public interface IRepositoryBase<TObject> where TObject : class
    {
        TObject GetOne(int id);
        TObject Add(TObject t);
        TObject Update(TObject t);
        void Delete(TObject t);

    }
}
