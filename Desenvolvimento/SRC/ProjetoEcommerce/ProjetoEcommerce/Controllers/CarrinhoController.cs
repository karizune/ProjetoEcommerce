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

        public JsonResult Remover(int carrinhoProdutoId)
        {
            try
            {
                var db = new ProjetoEcommerceContext();

                var removerCarrinho = db.carrinhoProduto.Find(carrinhoProdutoId);

                db.carrinhoProduto.Remove(removerCarrinho);
                db.SaveChanges();

                return Json(new { status = 1, message = "You're fired!" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = 0, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}