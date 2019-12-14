using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class RelatorioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Relatorios

        public ActionResult ListarTodos()
        {
            var Relatorios =
                new ProjetoEcommerceContext()
                .Relatorio
                .Where(f => f.Status == 1);

            return View(Relatorios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            ViewBag.Relatorios =
                new ProjetoEcommerceContext()
                .Relatorio
                .Where(f => f.Status == 1);

            return View();
        }
        [HttpPost]
        public ActionResult IncluirConfirm(Relatorio ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Usuario = "Walber";
            ent.Status = 1;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Relatorio.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
        public ActionResult Excluir(int RelatorioId)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.Relatorio.Find(RelatorioId);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "Walber";
            db.Entry<Relatorio>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("ListarTodos");

        }
    }
}