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
        public ActionResult IncluirConfirm(Formulario form)
        {
            var db = new ProjetoEcommerceContext();

            form.Descricao = "TesteShow";
            form.URL = "Https://testeshow.com.br";
            form.Usuario = "TesteShow";
            form.Status = 1;
            form.CriadoEm = DateTime.Now;
            form.AtualizadoEm = DateTime.Now;
            db.Formulario.Add(form);
            db.SaveChanges();

            return Redirect("ListarTodos");            
        }
    }
}