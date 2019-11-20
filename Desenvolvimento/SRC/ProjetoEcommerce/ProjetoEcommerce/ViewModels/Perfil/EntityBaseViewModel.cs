using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class EntityBaseViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime CriadoEm { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime AtualizadoEm { get; set; }
    }
}