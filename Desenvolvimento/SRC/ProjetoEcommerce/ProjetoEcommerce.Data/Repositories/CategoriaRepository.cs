
using System.Collections.Generic;
using System.Linq;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class CategoriaRepository:RepositoryBase<Categoria>,ICategoriaRepository
    {
        public IEnumerable<Categoria> BuscarAtivos()
        {
            return Entity.Where(f => f.Status == 1);
        }

        public Categoria GetOneBy(int CategoriaID)
        {
            return GetOne(CategoriaID);
        }
    }
}
