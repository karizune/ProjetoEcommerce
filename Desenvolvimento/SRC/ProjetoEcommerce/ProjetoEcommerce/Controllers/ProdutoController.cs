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

            produtos = produtos.Where(f => f.ProdutoID == 1).ToList();

            return View("Index", produtos);
        }

        [HttpPost]
        public ActionResult Adicionar(List<Produto> produtos)
        {
            var db = new ProjetoEcommerceContext();
            foreach (var produto in produtos)
            {

                if (produto.Qtde > 0)
                {
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