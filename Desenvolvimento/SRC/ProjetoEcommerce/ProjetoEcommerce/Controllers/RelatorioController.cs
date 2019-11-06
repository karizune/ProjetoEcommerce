using ProjetoEcommerce.data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class RelatorioController : Controller
    {
        /* private static List<Relatorio> Relatorios { get; set; }

        public RelatorioController()
        {
            Relatorios = new List<Relatorio>();
            Relatorios.Add(new Relatorio
            {
                RelatorioID = 1,
                Nome = "Cristina",
                Descricao = "Oi",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });
            Relatorios.Add(new Relatorio
            {
                RelatorioID = 2,
                Nome = "Maria",
                Descricao = "Oi",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });
            Relatorios.Add(new Relatorio
            {
                RelatorioID = 3,
                Nome = "Carla",
                Descricao = "Oi",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });

        }
 
   
        // GET: Relatorio
        public ActionResult ListarTodos()
        {
            return View(Relatorios);
        }*/

        public ActionResult Index()
        {
            return View();
        }

        // GET: Relatorios

        public ActionResult ListarTodos()
        {
            var Relatorios =
                new ProjetoEcommerceContext()
                .Relatorio
                .ToList();

            return View(Relatorios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Relatorio ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.RelatorioID = 1;
            ent.Nome = "Gabriel";
            ent.Descricao = "2";
            ent.Usuario = "Carlos";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Relatorio.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}