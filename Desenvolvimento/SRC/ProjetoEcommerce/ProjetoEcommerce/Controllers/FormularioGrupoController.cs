using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FormularioGrupoController : Controller
    {
        private readonly ProjetoEcommerceContext db;

        public FormularioGrupoController()
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
            var ListFormularioGrupo = db.FormularioGrupo
                .Include("Formulario")
                .Include("GrupoDeAcesso")
                .Where(f => f.Status == 1);   

            return View(ListFormularioGrupo);
        }
        public ActionResult Incluir()
        {
            ViewBag.Formularios = db.Formulario
                .Where(f => f.Status == 1)
                .ToList();
            ViewBag.Grupos = db.GrupoDeAcessos
                .Where(f => f.Status == 1)
                .ToList();

            var obj = new FormularioGrupo();

            return View(obj);
        }
        [HttpPost]
        public ActionResult IncluirConfirm(FormularioGrupo formGrupo)
        {
            var result = db.FormularioGrupo
                .Where(x => x.FormularioID == formGrupo.FormularioID && x.GrupoDeAcessoID == formGrupo.GrupoDeAcessoID)
                .FirstOrDefault();
            if (result == null)
            {
                formGrupo.AtualizadoEm = DateTime.Now;
                formGrupo.CriadoEm = DateTime.Now;
                formGrupo.Status = 1;
                formGrupo.Usuario = "Adriano";

                db.FormularioGrupo.Add(formGrupo);
            }
            else
            {
                result.Status = 1;
                result.Usuario = "Adriano";
                db.Entry<FormularioGrupo>(result).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();

            return RedirectToAction("ListarTodos");
        }
        public ActionResult Delete(int FormID,int GrupoDeAcessoID)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.FormularioGrupo.Find(FormID, GrupoDeAcessoID);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "Adriano";
            db.Entry<FormularioGrupo>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("ListarTodos");
        }
    }
}