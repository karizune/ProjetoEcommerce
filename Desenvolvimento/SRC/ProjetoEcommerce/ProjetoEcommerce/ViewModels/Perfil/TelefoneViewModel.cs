using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class TelefoneViewModel : EntityBaseViewModel
    {    
        public int? IDTelefone { get; set; }   
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DDD { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Tipo { get; set; } //celular, residencial, corporativo
        public ClienteViewModel cliente { get; set; }
    }
}