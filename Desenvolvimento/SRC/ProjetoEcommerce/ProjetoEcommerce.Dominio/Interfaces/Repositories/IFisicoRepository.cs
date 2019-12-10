using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IFisicoRepository : IRepositoryBase<Fisico>
    {
        IEnumerable<Fisico> BuscarAtivos();
    }
}
