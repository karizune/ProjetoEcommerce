using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    
    public class Email : EntityBase
    {
        public int IDEmail { get; set; }
        public int IDCliente { get; set; }
        public string E_mail { get; set; }
        public bool Tipo { get; set; } // Principal
        public Cliente CLiente { get; set; }

    }
}
