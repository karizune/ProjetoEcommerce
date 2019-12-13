using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface IJuridicoService : IServiceBase<Juridico>
    {
        bool Salvar(Juridico ent);
        IEnumerable<Juridico> BuscarAtivos();
    }
}
