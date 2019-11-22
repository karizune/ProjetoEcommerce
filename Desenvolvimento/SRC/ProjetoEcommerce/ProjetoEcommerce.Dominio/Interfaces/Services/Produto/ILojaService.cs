using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface ILojaService
    {
        bool Excluir(int categoriaId, string usuario);
        bool Salvar(Loja categoria);
        Loja GetOneBy(int CategoriaID);
        IEnumerable<Loja> BuscarAtivos();
    }
}
