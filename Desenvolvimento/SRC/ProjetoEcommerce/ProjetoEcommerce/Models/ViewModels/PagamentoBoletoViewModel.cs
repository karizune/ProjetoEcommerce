using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagamentoBoletoViewModel
    {
        public string EmailPagador { get; set; }
        public string CPFPagador { get; set; }
        public string TelefonePagador { get; set; }
        public string NomePagador { get; set; }
    }
}