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
        // GET: FormularioGrupo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListarTodos()
        {
            var ListFormularioGrupo = new ProjetoEcommerceContext().FormularioGrupo.ToList();

            return View(ListFormularioGrupo);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IncluirConfirm(FormularioGrupo formGrupo)
        {
            var db = new ProjetoEcommerceContext();

            formGrupo.AtualizadoEm= DateTime.Now;
            formGrupo.CriadoEm = DateTime.Now;
            formGrupo.Status = 1;
            formGrupo.Usuario = "Teste";

            return View("ListarTodos");
        }
    }
}