using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class GrupoUsuarioController : Controller
    {
        // GET: GrupoUsuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            var listGrupoUsuario = new ProjetoEcommerceContext().GrupoUsuario.ToList();

            return View(listGrupoUsuario);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(GrupoUsuario grupoUsuario)
        {
            var db = new ProjetoEcommerceContext();

            grupoUsuario.UsuarioID = 1;
            grupoUsuario.GrupoID =1;
            

            grupoUsuario.Usuario = "TesteShow";
            grupoUsuario.Status = 1;
            grupoUsuario.CriadoEm = DateTime.Now;
            grupoUsuario.AtualizadoEm = DateTime.Now;

            db.GrupoUsuario.Add(grupoUsuario);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}