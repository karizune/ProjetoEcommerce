using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface ILojaRepository : IRepositoryBase<Loja>
    {
        Loja GetOneBy(int LojaID);
        IEnumerable<Loja> BuscarAtivos();
    }
}
