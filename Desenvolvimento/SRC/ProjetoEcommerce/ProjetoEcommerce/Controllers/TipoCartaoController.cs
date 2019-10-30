using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class TipoCartaoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoCartao
        public ActionResult ListarTodos()
        {
            var tiposDeCartoes =
                new ProjetoEcommerceContext()
                    .TipoCartao
                    .ToList();

            return View(tiposDeCartoes);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult IncluirConfirm(TipoCartao ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Status = 1;
            ent.Usuario = "renato";
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.TipoCartao.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}