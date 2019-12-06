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

            return View("Index", 1);
        }

        public ActionResult ResumoCarrinho(int usuarioId)
        {
            var resumoCarrinho = new Carrinho();
            using (var db = new ProjetoEcommerceContext())
            {
                resumoCarrinho = db.Set<Carrinho>().Where(f => f.UsuarioID == usuarioId).FirstOrDefault();
            }

            AtualizarPrecoCarrinho(usuarioId);

            return PartialView("_ResumoCarrinho", resumoCarrinho);
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


        public void AtualizarPrecoCarrinho(int usuarioID)
        {
            using (var db = new ProjetoEcommerceContext())
            {
                var result = db.Set<Carrinho>().Where(f => f.UsuarioID == usuarioID).FirstOrDefault();
                if (result != null)
                {
                    var carrinhoProdutos =
                        new ProjetoEcommerceContext()
                            .carrinhoProduto
                            .Include("Produto")
                            .ToList();

                    result.PrecoTotal = carrinhoProdutos.Sum(x => x.Produto.Preco * x.Quantidade);

                    db.SaveChanges();
                }

            }
        }

    }
}