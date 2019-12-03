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
    public class LojaRepository : RepositoryBase<Loja>, ILojaRepository  
    {
        public IEnumerable<Loja> BuscarAtivos()
        {
            throw new NotImplementedException();
        }

        public Loja GetOneBy(int LojaID)
        {
            throw new NotImplementedException();
        }
    }
}
