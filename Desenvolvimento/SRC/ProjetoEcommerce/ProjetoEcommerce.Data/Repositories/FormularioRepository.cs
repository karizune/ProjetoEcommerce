using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories.Base
{
    public class FormularioRepository : RepositoryBase<Formulario>, IFormularioRepository
    {
        public IEnumerable<Formulario> BuscarAtivos()
        {
            return Entity.Where(f => f.Status == 1);
        }

        public IEnumerable<Formulario> BuscarTodos()
        {
            return Entity.ToList();
        }

    }
}
