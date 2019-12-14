using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class GrupoDeAcessoController : Controller
    {
        private readonly ProjetoEcommerceContext db;
        public GrupoDeAcessoController()
        {
            db = new ProjetoEcommerceContext();
        }
        // GET: GrupoDeAcesso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            //var listGrupo = new ProjetoEcommerceContext().GrupoDeAcessos.ToList();

            //return View(listGrupo);
            var ListGrupoDeAcesso = db.GrupoDeAcessos
                .Where(f => f.Status == 1);

            return View(ListGrupoDeAcesso);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(GrupoDeAcesso grupo)
        {
            var db = new ProjetoEcommerceContext();

            
            grupo.Usuario = "TesteShow";
            grupo.Status = 1;
            grupo.CriadoEm = DateTime.Now;
            grupo.AtualizadoEm = DateTime.Now;

            db.GrupoDeAcessos.Add(grupo);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
        public ActionResult Delete(int id)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.GrupoDeAcessos.Find(id);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "deleteeeeeeeeee carai";
            db.Entry<GrupoDeAcesso>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListarTodos");
        }
    }
}