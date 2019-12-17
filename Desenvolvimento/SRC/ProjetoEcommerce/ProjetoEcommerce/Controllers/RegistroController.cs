using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class RegistroController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro

        public ActionResult ListarTodos()
        {
            var Registros =
                new ProjetoEcommerceContext()
                .Registro
                .Where(f => f.Status == 1);

            return View(Registros);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            ViewBag.Relatorios =
                new ProjetoEcommerceContext()
                .Relatorio
               .Where(f => f.Status == 1);
            ViewBag.Usuarios =
                new ProjetoEcommerceContext()
                .Usuario
                .Where(f => f.Status == 1);
            return View();

        }

        [HttpPost]
        public ActionResult IncluirConfirm(Registro ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Usuario = "Carlos";
            ent.Status = 1;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Registro.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }

        public ActionResult Excluir(int RelatorioID,int UsuarioID)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.Registro.Find(RelatorioID, UsuarioID );
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "renato";
            db.Entry<Registro>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}