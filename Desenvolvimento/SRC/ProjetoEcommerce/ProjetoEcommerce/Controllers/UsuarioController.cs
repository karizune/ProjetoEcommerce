using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult ListarTodos()
        {
            var Usuarios =
                new ProjetoEcommerceContext()
                .Usuario
                .ToList();

            return View(Usuarios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Usuario ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.UsuarioID = 1;
            //ent.NomeUsuario = "";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Usuario.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}