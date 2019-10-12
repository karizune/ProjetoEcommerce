using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public class Email
    {
        public int IDEmail { get; set; }
        public int IDCliente { get; set; }
        public string E_mail { get; set; }
        public bool Status { get; set; }
        public bool Tipo { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
