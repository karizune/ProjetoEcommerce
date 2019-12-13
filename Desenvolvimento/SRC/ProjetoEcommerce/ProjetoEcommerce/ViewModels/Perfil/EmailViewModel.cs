using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class EmailViewModel : EntityBaseViewModel
    {        
        public int? IDEmail { get; set; }
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string E_mail { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Tipo { get; set; } // Principal
        public virtual ClienteViewModel CLiente { get; set; }
    }
}