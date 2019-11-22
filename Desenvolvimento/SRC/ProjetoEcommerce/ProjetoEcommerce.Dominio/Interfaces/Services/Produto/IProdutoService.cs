using ProjetoEcommerce.Dominio.Entidades.Produto;
using System.Collections.Generic;


namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface IProdutoService
    {
        bool Excluir(int produtoId, string usuario);
        bool Salvar(Produto produto);
        Produto GetOneBy(int ProdutoID);
        IEnumerable<Produto> BuscarAtivos();
    }
}
