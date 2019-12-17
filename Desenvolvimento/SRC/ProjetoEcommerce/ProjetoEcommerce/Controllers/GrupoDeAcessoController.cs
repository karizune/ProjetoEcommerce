using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class GrupoDeAcessoController : Controller
    {
        //Formulario form = new Formulario();
        private readonly ProjetoEcommerceContext db;

        private readonly IGrupoDeAcessoRepository _grupoDeAcessoRepository;

        public GrupoDeAcessoController()
        {
            _grupoDeAcessoRepository = new GrupoDeAcessoRepository();
            db = new ProjetoEcommerceContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            var ListGrupoDeAcesso = db.GrupoDeAcessos
                 .Where(f => f.Status == 1);
            return View(ListGrupoDeAcesso);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(GrupoDeAcesso grupoDeAcesso)
        {
            var result = db.GrupoDeAcessos.Where(x => x.GrupoDeAcessoID == grupoDeAcesso.GrupoDeAcessoID).FirstOrDefault();
            if (result == null)
            {
                grupoDeAcesso.AtualizadoEm = DateTime.Now;
                grupoDeAcesso.CriadoEm = DateTime.Now;
                grupoDeAcesso.Status = 1;
                grupoDeAcesso.Usuario = "Adriano";

                db.GrupoDeAcessos.Add(grupoDeAcesso);
            }
            else
            {
                result.Status = 1;
                result.Usuario = "Adriano";
                db.Entry<GrupoDeAcesso>(result).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();

            return RedirectToAction("ListarTodos");
        }

        public ActionResult Delete(int id)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.GrupoDeAcessos.Find(id);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "Adriano";
            db.Entry<GrupoDeAcesso>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListarTodos");
        }
    }
}
