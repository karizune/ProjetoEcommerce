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
            var ListFormularioGrupo = db.FormularioGrupo.ToList();

            return View(ListFormularioGrupo);
        }
        public ActionResult Incluir()
        {
            ViewBag.Formularios = db.Formulario.ToList();
            ViewBag.Grupos = db.GrupoDeAcessos.ToList();

            var obj = new FormularioGrupo();

            return View(obj);
        }
        [HttpPost]
        public ActionResult IncluirConfirm(FormularioGrupo formGrupo)
        {
            formGrupo.AtualizadoEm= DateTime.Now;
            formGrupo.CriadoEm = DateTime.Now;
            formGrupo.Status = 1;
            formGrupo.Usuario = "Teste";

            db.FormularioGrupo.Add(formGrupo);
            db.SaveChanges();

            return View("ListarTodos");
        }
    }
}