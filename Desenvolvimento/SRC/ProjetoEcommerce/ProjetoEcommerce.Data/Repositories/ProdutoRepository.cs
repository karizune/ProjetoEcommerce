
using System.Collections.Generic;
using System.Linq;
using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;

namespace ProjetoEcommerce.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarAtivos()
        {
            return Entity.Where(f => f.Status == 1);
        }

        public Produto GetOneBy(int ProdutoID)
        {
            return GetOne(ProdutoID);
        }
    }
}
