using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public class Telefone
    {
        public int IDTelefone { get; set; }
        public int IDCliente { get; set; }
        public string Numero { get; set; }
        public string DDD { get; set; }
        public bool Status { get; set; }
        public string Tipo { get; set; } //celular, residencial, corporativo
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public Cliente cliente { get; set; }

    }
}
