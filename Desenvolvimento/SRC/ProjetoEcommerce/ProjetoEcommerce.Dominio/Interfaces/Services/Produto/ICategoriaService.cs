using ProjetoEcommerce.Dominio.Entidades.Produto;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface ICategoriaService
    {
        bool Excluir(int categoriaId, string usuario);
        bool Salvar(Categoria categoria);
        Categoria GetOneBy(int CategoriaID);
        IEnumerable<Categoria> BuscarAtivos();
    }
}
