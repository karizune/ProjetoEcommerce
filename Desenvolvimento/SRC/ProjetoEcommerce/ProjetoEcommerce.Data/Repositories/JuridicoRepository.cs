using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class JuridicoRepository : RepositoryBase<Juridico>, IJuridicoRepository
    {
        public IEnumerable<Juridico> BuscarAtivos()
        {
            return Db
                .juridico
                .Where(f => f.Status == true);
        }
    }
}
