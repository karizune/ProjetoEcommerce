using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> Produtos { get; set; }


        // GET: Produto
        public ActionResult Index()
        {
            return View(Produtos);
        }
    }
}