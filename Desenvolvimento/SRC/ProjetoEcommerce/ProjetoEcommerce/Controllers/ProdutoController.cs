using ProjetoEcommerce.Dominio.Entidades.Produto;
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
        public ActionResult ListarTodas()
        {
            var categorias =
                new ProjetoEcommerceContext()
                .Categoria
                .ToList();

            return View(categorias);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Categoria ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Status = 1;
            ent.Usuario = "grupo4";
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Categoria.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodas");
        }
    }
}