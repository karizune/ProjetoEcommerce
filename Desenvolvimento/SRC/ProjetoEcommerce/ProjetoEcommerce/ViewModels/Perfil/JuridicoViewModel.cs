using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class JuridicoViewModel : ClienteViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string InscricaoEstatual { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Responsavel { get; set; }
    }
}