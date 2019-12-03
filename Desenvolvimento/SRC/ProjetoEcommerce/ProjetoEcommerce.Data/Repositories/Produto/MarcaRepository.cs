using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories
{
    class MarcaRepository : RepositoryBase<Marca>, IMarcaRepository
    {
        public IEnumerable<Marca> BuscarAtivos()
        {
            throw new NotImplementedException();
        }

        public Marca GetOneBy(int MarcaID)
        {
            throw new NotImplementedException();
        }
    }
}
