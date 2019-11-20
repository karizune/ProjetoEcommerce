using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class PagamentoController : Controller
    {
        // GET: Pagamento
        public ActionResult Pagar()
        {
            IEnumerable<Produto> ListaProdutos = new List<Produto>();
            return View(ListaProdutos);
        }
    }
}