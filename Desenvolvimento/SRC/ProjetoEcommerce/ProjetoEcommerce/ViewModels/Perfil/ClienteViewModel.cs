using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public abstract class ClienteViewModel : EntityBaseViewModel
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Tipo { get; set; }
        public string Foto { get; set; }
        public List<TelefoneViewModel> Telefones { get; set; }
        public List<EmailViewModel> Email { get; set; }
    }
}