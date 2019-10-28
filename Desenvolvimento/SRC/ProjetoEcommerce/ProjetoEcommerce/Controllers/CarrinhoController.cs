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

            List<Produto> lista = new List<Produto>();

            Produto p1 = new Produto {
                Nome = "Livro",
                Qtd = 9,
                Preco = 270
            };
            Produto p2 = new Produto {
                Nome = "DM Screen do Germano",
                Qtd = 1,
                Preco = 200
            };
            Produto p3 = new Produto {
                Nome = "Sabao",
                Qtd = 2,
                Preco = 10
            };

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);



            return View("Index",lista);
        }
    }
}