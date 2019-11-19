using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class TelefoneViewModel : EntityBaseViewModel
    {
        public int IDTelefone { get; set; }
        public int IDCliente { get; set; }
        public string Numero { get; set; }
        public string DDD { get; set; }
        public string Tipo { get; set; } //celular, residencial, corporativo
        public ClienteViewModel cliente { get; set; }
    }
}