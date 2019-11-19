using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class JuridicoViewModel : ClienteViewModel
    {
        public string CNPJ { get; set; }
        public string InscricaoEstatual { get; set; }
        public string Responsavel { get; set; }
    }
}