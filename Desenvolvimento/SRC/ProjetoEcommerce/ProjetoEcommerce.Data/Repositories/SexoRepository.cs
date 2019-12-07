using System.Collections.Generic;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class SexoRepository : RepositoryBase<Sexo>, ISexoRepository
    {
        public IEnumerable<Sexo> BuscarAtivos()
        {
            return Db
                .Sexo
                .Where(f => f.Status == true);
        }
    }
}
