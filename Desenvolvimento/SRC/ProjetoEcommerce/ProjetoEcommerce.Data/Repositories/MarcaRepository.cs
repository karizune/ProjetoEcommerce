
using System.Collections.Generic;
using System.Linq;
using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;

namespace ProjetoEcommerce.Data.Repositories
{
    public class MarcaRepository : RepositoryBase<Marca>, IMarcaRepository
    {
        public IEnumerable<Marca> BuscarAtivos()
        {
            return Entity.Where(f => f.Status == 1);
        }

        public Marca GetOneBy(int MarcaID)
        {
            return GetOne(MarcaID);
        }

    }
}
