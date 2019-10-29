using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CampoController : Controller
    {
        private static List<Campo> campos { get; set; }

        public CampoController()
        {
            campos = new List<Campo>();
            campos.Add(new Campo
            {
                CampoID = 1,
                Nome = "Fernando",
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 1

            });
            campos.Add(new Campo
            {
                CampoID = 2,
                Nome = "Cristina",
                Usuario = "Gabriel",
                Status = 2,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 2

            });
            campos.Add(new Campo
            {
                CampoID = 3,
                Nome = "Francielly",
                Usuario = "Gabriel",
                Status = 3,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now,
                TipoCampoID = 3

            });
        }

        // GET: Campo

        public ActionResult ListarTodos()
        {
            return View(campos);
        }

    }


}
