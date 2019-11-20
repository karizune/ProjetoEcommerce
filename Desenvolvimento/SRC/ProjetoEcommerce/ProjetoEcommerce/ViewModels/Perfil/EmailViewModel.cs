using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class EmailViewModel : EntityBaseViewModel
    {
        [Required]
        public int IDEmail { get; set; }
        [Required]
        public int IDCliente { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress]
        public string E_mail { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Tipo { get; set; } // Principal
        public virtual ClienteViewModel CLiente { get; set; }
    }
}