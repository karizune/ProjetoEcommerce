
using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class CategoriaRepository:RepositoryBase<Categoria>,ICategoriaRepository
    {
        public Categoria GetOneBy(int CategoriaID)
        {
            return GetOne(CategoriaID);
        }
    }
}
