using ProjetoEcommerce.Dominio.Entidades.Pagamento.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class PagarController : Controller
    {
        
        public ActionResult Pagar(IEnumerable<ProdutoCarrinho> ListaProdutos)
        {
            return View(new PagarViewModel(ListaProdutos));
        }

    }

   
}