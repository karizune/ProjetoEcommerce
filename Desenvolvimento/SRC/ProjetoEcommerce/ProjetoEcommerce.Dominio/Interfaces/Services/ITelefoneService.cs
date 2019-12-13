using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface ITelefoneService : IServiceBase<Telefone>
    {
        bool Salvar(Telefone ent);
        IEnumerable<Telefone> BuscarAtivos();
    }
}
