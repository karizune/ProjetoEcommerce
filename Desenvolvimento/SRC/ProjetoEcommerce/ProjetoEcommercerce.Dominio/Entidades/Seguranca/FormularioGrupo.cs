using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Seguranca
{
    public class FormularioGrupo
    {
        public int FormularioID { get; set; }
        public int GrupoID { get; set; }
        public Formulario Formulario { get; set; }
        public GrupoDeAcesso GrupoDeAcesso { get; set; }
    }
}
