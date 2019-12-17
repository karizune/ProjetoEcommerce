using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{

    public class CampoRelatorioController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // GET: CampoRelatorio

        public ActionResult ListarTodos()
        {

            var CamposRelatorios =
                new ProjetoEcommerceContext()
                .CampoRelatorio
                .Where(f => f.Status == 1);

            return View(CamposRelatorios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            ViewBag.Campos =
                new ProjetoEcommerceContext()
                .Campo
                .Where(f => f.Status == 1);

            ViewBag.Relatorios =
                new ProjetoEcommerceContext()
                .Relatorio
                .Where(f => f.Status == 1);

            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(CampoRelatorio ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Usuario = "Gabriel";
            ent.Status = 1;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.CampoRelatorio.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
        public ActionResult Excluir(int relatorioId, int campoId)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.CampoRelatorio.Find(relatorioId, campoId);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "Walberson";
            db.Entry<CampoRelatorio>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}