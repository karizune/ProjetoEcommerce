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
        // GET: GrupoDeAcesso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            var listGrupo = new ProjetoEcommerceContext().GrupoDeAcessos.ToList();

            return View(listGrupo);
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
    }
}