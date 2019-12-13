using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IJuridicoRepository : IRepositoryBase<Juridico>
    {
        IEnumerable<Juridico> BuscarAtivos();
    }
}
