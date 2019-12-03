using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FormularioController : Controller
    {
        Formulario form = new Formulario();
        ProjetoEcommerceContext db = new ProjetoEcommerceContext();
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            var listFormulario = new ProjetoEcommerceContext().Formulario.ToList();

            return View(listFormulario);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm()
        {
            //var db = new ProjetoEcommerceContext();

            form.Usuario = "TesteShow";
            form.Status = 1;
            form.CriadoEm = DateTime.Now;
            form.AtualizadoEm = DateTime.Now;
            db.Formulario.Add(form);
            db.SaveChanges();
            
            return Redirect("ListarTodos");            
        }

        public ActionResult Delete(int id)
        {
            //var db = new ProjetoEcommerceContext();

            Formulario formulario = db.Formulario.First(x => x.FormularioID == id);
            db.Formulario.Remove(formulario);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}
