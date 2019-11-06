using ProjetoEcommerce.data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class RegistroController : Controller
    {
        /* private static List<Registro> Registros { get; set; }

        public RegistroController()
        {
            Registros = new List<Registro>();
            Registros.Add(new Registro
            {
                RelatorioID = 1,
                UsuarioID = 1,
                Nome = "Cristina",
                Descricao = "Oi",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });
            Registros.Add(new Registro
            {
                RelatorioID = 2,
                UsuarioID = 2,
                Nome = "Francielly",
                Descricao = "Oi",
                Usuario = "Gabriel",
                Status = 2,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });
            Registros.Add(new Registro
            {
                RelatorioID = 3,
                UsuarioID = 3,
                Nome = "Samanta",
                Descricao = "Oi",
                Usuario = "Gabriel",
                Status = 3,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

            });

        }
 
   
        // GET: Registro
        public ActionResult ListarTodos()
        {
            return View(Registros);
        }*/

        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro

        public ActionResult ListarTodos()
        {
            var Registros =
                new ProjetoEcommerceContext()
                .Registro
                .ToList();

            return View(Registros);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Registro ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.RelatorioID = 1;
            ent.UsuarioID = 2;
            ent.Nome = "Gabriel";
            ent.Descricao = "2";
            ent.Usuario = "Carlos";
            ent.Status = 2;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Registro.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}