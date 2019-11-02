using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Seguranca
{
    public class GrupoDeAcesso : BaseEntity
    {
        public int GrupoID { get; set; }
        public string Descricao { get; set; }

    }
}
