using ProjetoEcommerce.data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{

    public class TipoCampoController : Controller
    {
         /*private static List<TipoCampo> TiposCampos { get; set; }

          public TipoCampoController()
          {
              TiposCampos = new List<TipoCampo>();
              TiposCampos.Add(new TipoCampo
              { 
                  TipoCampoID = 1,
                  Descricao = "Salve",
                  Usuario = "Walber",
                  Status = 1,
                  CriadoEm = DateTime.Now,
                  AtualizadoEm = DateTime.Now

              });
          }


        public ActionResult ListarTodos()
        {
            return View();
        }
        */
        // GET : TipoCampo

        public ActionResult ListarTodos()
        {
            var TiposCampos =
                new ProjetoEcommerceContext()
                .TipoCampo
                .ToList();

            return View(TiposCampos);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(TipoCampo ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Usuario = "Fellipe";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.TipoCampo.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}