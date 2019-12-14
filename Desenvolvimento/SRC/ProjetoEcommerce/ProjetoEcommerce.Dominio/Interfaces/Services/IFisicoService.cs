using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface IFisicoService : IServiceBase<Fisico>
    {
        bool Salvar(Fisico ent);
        IEnumerable<Fisico> BuscarAtivos();
        Cliente Autenticar(string email, string senha);
    }
}
