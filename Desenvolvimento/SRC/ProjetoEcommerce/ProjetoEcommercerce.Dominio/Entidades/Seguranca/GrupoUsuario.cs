using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Seguranca
{
    public class GrupoUsuario
    {
        public int UsuarioID { get; set; }
        public int GrupoID { get; set; }
        public GrupoDeAcesso GrupoDeAcesso { get; set; }
        //public UsuarioID UsuarioID { get; set; }
    }
}
