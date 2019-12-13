using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface IEmailService : IServiceBase<Email>
    {
        bool Salvar(Email ent);
        IEnumerable<Email> BuscarAtivos();
    }
}
