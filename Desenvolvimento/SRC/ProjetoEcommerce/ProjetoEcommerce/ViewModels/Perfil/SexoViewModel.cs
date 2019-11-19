using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class SexoViewModel : EntityBaseViewModel
    {
        public int IDSexo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}