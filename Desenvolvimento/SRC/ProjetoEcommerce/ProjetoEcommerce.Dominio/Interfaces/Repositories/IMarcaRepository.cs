using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IMarcaRepository : IRepositoryBase<Marca>
    {
        Marca GetOneBy(int MarcaID);
        IEnumerable<Marca> BuscarAtivos();
    }
}
