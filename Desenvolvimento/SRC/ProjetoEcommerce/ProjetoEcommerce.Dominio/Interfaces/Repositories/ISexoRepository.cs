using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface ISexoRepository : IRepositoryBase<Sexo>
    {
        IEnumerable<Sexo> BuscarAtivos();
    }
}
