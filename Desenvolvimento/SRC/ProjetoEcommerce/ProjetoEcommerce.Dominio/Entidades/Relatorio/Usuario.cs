using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Relatorio
{
    public class Usuario : IEntidadeBase
    {
        public int UsuarioID { get; set; }
        public int Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        string IEntidadeBase.Usuario { get; set; }
    }
}
