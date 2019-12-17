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
        private readonly ProjetoEcommerceContext db;

        public class user
        {
            public int UsuarioID { get; set; }
            public String Nome { get; set; }
        }

        public GrupoUsuarioController()
        {
            db = new ProjetoEcommerceContext();
        }
        // GET: FormularioGrupo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListarTodos()
        {
            var ListGrupoUsuario = db.GrupoUsuario
                .Where(f => f.Status == 1);
            return View(ListGrupoUsuario);
        }
        public ActionResult Incluir()
        {            
            List<user> users = new List<user>();
            for (int i = 0; i < 3; i++)
            {
                user u = new user();
                u.UsuarioID = i;
                u.Nome = "usuario" + i;
                users.Add(u);
            }

            ViewBag.Usuarios = users;
            ViewBag.Grupos = db.GrupoDeAcessos
                .Where(f=>f.Status == 1)
                .ToList();

            var obj = new GrupoUsuario();

            return View(obj);
        }
        [HttpPost]
        public ActionResult IncluirConfirm(GrupoUsuario grupoUsuario)
        {           
            grupoUsuario.AtualizadoEm = DateTime.Now;
            grupoUsuario.CriadoEm = DateTime.Now;
            grupoUsuario.Status = 1;
            grupoUsuario.Usuario = "Adriano";
            db.GrupoUsuario.Add(grupoUsuario);
            db.SaveChanges();

            return View("ListarTodos");
        }

        public ActionResult Delete(int grupoID, int usuarioID)
        {
            var ent = db.GrupoUsuario.Find(grupoID, usuarioID);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "Adriano";
            db.Entry<GrupoUsuario>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ListarTodos");
        }
    }
}