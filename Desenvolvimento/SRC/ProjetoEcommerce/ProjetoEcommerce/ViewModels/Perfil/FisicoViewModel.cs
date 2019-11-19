using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class FisicoViewModel : ClienteViewModel
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IDSexo { get; set; }
        public virtual SexoViewModel Sexo { get; set; }
    }
}