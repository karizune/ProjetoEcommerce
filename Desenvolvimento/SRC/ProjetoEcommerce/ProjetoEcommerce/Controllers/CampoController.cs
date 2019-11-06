using ProjetoEcommerce.data.EntityFramework.Context;
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
                .ToList();

            return View(Campos);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Campo ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.CampoID = 1;
            ent.Nome = "Gabriel";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            ent.TipoCampoID = 2;
            db.Campo.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }

    }


}
