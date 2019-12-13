using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CampoController : Controller
    {
        /*
        private static List<Campo> campos { get; set; }

        public CampoController()
        {
            campos = new List<Campo>();
            campos.Add(new Campo
            {
                CampoID = 1,
                Nome = "Fernando",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 1

            });
            campos.Add(new Campo
            {
                CampoID = 2,
                Nome = "Cristina",
                Usuario = "Gabriel",
                Status = 2,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 2

            });
            campos.Add(new Campo
            {
                CampoID = 3,
                Nome = "Francielly",
                Usuario = "Gabriel",
                Status = 3,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 3

            });
        }
        

        // GET: Campo

        public ActionResult ListarTodos()
        {
            return View();
        }
        */

        // GET: Campo
        public ActionResult ListarTodos()
        {
            var Campos =
                new ProjetoEcommerceContext()
                .Campo
                .Where(f => f.Status == 1);

            return View(Campos);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            ViewBag.TipoCampos =
                new ProjetoEcommerceContext()
                .TipoCampo
                .Where(f => f.Status == 1);

            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Campo ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Usuario = "CJ";
            ent.Status = 1;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Campo.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
        public ActionResult Excluir(int CampoID)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.Campo.Find(CampoID);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "renato";
            db.Entry<Campo>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("Index");
        }

        public ActionResult Excluir(int CampoId)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.Campo.Find(CampoId);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "renato";
            db.Entry<Campo>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("ListarTodos");

        }
     }

}
