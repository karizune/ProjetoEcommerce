using ProjetoEcommerce.data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{

    public class CampoRelatorioController : Controller
    {
        /*  private static List<CampoRelatorio> CamposRelatorios { get; set; }

          public CampoRelatorioController()
          {
              CamposRelatorios = new List<CampoRelatorio>();
              CamposRelatorios.Add(new CampoRelatorio
              { 
                  RelatorioID = 1,
                  CampoID = 1,
                  Usuario = "Carlos",
                  Status = 1,
                  CriadoEm = DateTime.Now,
                  AtualizadoEm = DateTime.Now

              });

              CamposRelatorios.Add(new CampoRelatorio
              {
                  RelatorioID = 2,
                  CampoID = 2,
                  Usuario = "Gabriel",
                  Status = 2,
                  CriadoEm = DateTime.Now,
                  AtualizadoEm = DateTime.Now

               });
              CamposRelatorios.Add(new CampoRelatorio
              {
                  RelatorioID = 3,
                  CampoID = 3,
                  Usuario = "Gabriel",
                  Status = 3,
                  CriadoEm = DateTime.Now,
                  AtualizadoEm = DateTime.Now

              });


          }

          // GET: CampoRelatorio
         public ActionResult ListarTodos()
          {
              return View(CamposRelatorios);
          }
       */
        public ActionResult Index()
        {
            return View();
        }

        // GET: CampoRelatorio

        public ActionResult ListarTodos()
        {
            var CamposRelatorios = 
                new ProjetoEcommerceContext()
                .CampoRelatorio
                .ToList();

            return View(CamposRelatorios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(CampoRelatorio ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.RelatorioID = 1;
            ent.CampoID = 2;
            ent.Usuario = "Gabriel";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.CampoRelatorio.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}