using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public abstract class ClienteViewModel : EntityBaseViewModel
    {
        [Required]
        public int IDCliente { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(8)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Tipo { get; set; }
        public string Foto { get; set; }
        public List<TelefoneViewModel> Telefones { get; set; }
        public List<EmailViewModel> Email { get; set; }
    }
}