using ProjetoEcommerce.Data.Context;
using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Categoria
        public ActionResult ListarTodas()
        {
            var Categoria =
                new ProjetoEcommerceContext()
                .Categoria
                .ToList();

            return View(Categoria);
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

            return Redirect("ListarTodos");
        }
    }
}