using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class FisicoRepository : RepositoryBase<Fisico>, IFisicoRepository
    {
        public IEnumerable<Fisico> BuscarAtivos()
        {
            return Db
                .fisico
                .Where(f => f.Status == true);
        }
    }
}
