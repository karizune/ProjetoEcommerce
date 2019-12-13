using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IEmailRepository : IRepositoryBase<Email>
    {
        IEnumerable<Email> BuscarAtivos();
    }
}
