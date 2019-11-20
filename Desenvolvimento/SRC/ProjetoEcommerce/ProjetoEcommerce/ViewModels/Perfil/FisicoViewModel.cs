using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class FisicoViewModel : ClienteViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }
        public int IDSexo { get; set; }
        public virtual SexoViewModel Sexo { get; set; }
    }
}