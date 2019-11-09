using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IImagemRepository : IRepositoryBase<Imagem>
    {
        Imagem GetOneBy(int ImagemID);
        IEnumerable<Imagem> BuscarAtivos();
    }
}
