using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult Index()
        {
            var carrinhoProduto =
                new ProjetoEcommerceContext()
                    .carrinhoProduto
                    .ToList();
            return View("Index", carrinhoProduto);

        }
    }
}