using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var produtos =
                new ProjetoEcommerceContext()
                    .produto
                    .ToList();

            ViewBag.QtdProdutos = produtos.Count;

            return View("Index", produtos);
        }

        public ActionResult ProdutoCarrinho()
        
        {
            var carrinhoProdutos =
                new ProjetoEcommerceContext()
                    .carrinhoProduto
                    .Include("Produto")
                    .ToList();
            return PartialView("_ProdutosCarrinho",carrinhoProdutos);
        }

        [HttpPost]
        public ActionResult Adicionar(List<Produto> produtos/*, int usuarioId*/)
        {   
            var db = new ProjetoEcommerceContext();
            foreach (var produto in produtos)
            {
                if (produto.Qtde > 0)
                {
                    //var produtoCarrinho = db.carrinhoProduto.Where(f => f.CarrinhoID == usuarioId).ToList();

                    var carrinhoProduto = new CarrinhoProduto
                    {
                        CarrinhoID = 1,
                        Status = 1,
                        Usuario = "Jose",
                        CriadoEm = DateTime.Now,
                        AtualizadoEm = DateTime.Now,

                        ProdutoID = produto.ProdutoID,
                        Quantidade = produto.Qtde,
                        PrecoTotal = produto.Preco * produto.Qtde,
                        //Produto = produto
                    };

                    db.carrinhoProduto.Add(carrinhoProduto);
                }
                
            }
                db.SaveChanges();
            return RedirectToAction("Index","Carrinho");
        }
    }
}