using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Seguranca
{
    public class GrupoUsuario : BaseEntity
    {
        public int UsuarioID { get; set; }
        public int GrupoDeAcessoID { get; set; }
        public GrupoDeAcesso GrupoDeAcesso { get; set; }
        //public Usuario UsuarioCad { get; set; }
    }
}
