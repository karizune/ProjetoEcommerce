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
            var carrinhoProdutos =
                new ProjetoEcommerceContext()
                    .carrinhoProduto
                    .Include("Produto")
                    .ToList();
            return View("Index", carrinhoProdutos);
        }

        [HttpPost]
        public ActionResult Remover(CarrinhoProduto carrinhoProdutos)
        {

            var db = new ProjetoEcommerceContext();

            var removerCarrinho = carrinhoProdutos;

            db.carrinhoProduto.Remove(removerCarrinho);
            db.SaveChanges();

            return RedirectToAction("Index", "Carrinho");
        }
    }
}