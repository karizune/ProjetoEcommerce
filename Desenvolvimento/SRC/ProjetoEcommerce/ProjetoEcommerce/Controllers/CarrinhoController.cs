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

            //List<CarrinhoProduto> lista = new List<CarrinhoProduto>();

            //Produto p1 = new Produto {
            //    Nome = "Livro",
            //    Preco = 270
            //};
            //Produto p2 = new Produto {
            //    Nome = "DM Screen do Germano",
            //    Preco = 200
            //};
            //Produto p3 = new Produto {
            //    Nome = "Sabao",
            //    Preco = 10
            //};

            //CarrinhoProduto carrinhoProduto1 = new CarrinhoProduto
            //{
            //    Produto = p1,
            //    Quantidade = 2
            //};
            //CarrinhoProduto carrinhoProduto2 = new CarrinhoProduto
            //{
            //    Produto = p2,
            //    Quantidade = 1
            //};
            //CarrinhoProduto carrinhoProduto3 = new CarrinhoProduto
            //{
            //    Produto = p3,
            //    Quantidade = 4
            //};

            //carrinhoProduto1.PrecoTotal = carrinhoProduto1.Produto.Preco * carrinhoProduto1.Quantidade;
            //carrinhoProduto2.PrecoTotal = carrinhoProduto2.Produto.Preco * carrinhoProduto2.Quantidade;
            //carrinhoProduto3.PrecoTotal = carrinhoProduto3.Produto.Preco * carrinhoProduto3.Quantidade;

            //lista.Add(carrinhoProduto1);
            //lista.Add(carrinhoProduto2);
            //lista.Add(carrinhoProduto3);




            var listaCarrinhoProduto =
                new ProjetoEcommerceContext()
                    .carrinhoProduto
                    .ToList();

            Carrinho carrinho = new Carrinho {
              PrecoFrete = 39,
              PrecoTotal = listaCarrinhoProduto.Sum(x => x.PrecoTotal)
            };

            ViewBag.Carrinho = carrinho;

            return View("Index", listaCarrinhoProduto);
        }

        
    }
}