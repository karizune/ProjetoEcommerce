using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class EmailViewModel : EntityBaseViewModel
    {
        public int IDEmail { get; set; }
        public int IDCliente { get; set; }
        public string E_mail { get; set; }
        public bool Tipo { get; set; } // Principal
        public virtual ClienteViewModel CLiente { get; set; }
    }
}