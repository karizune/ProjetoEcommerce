using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{

    public class CampoRelatorioController : Controller
    {
        private static List<CampoRelatorio> CamposRelatorios { get; set; }

        public CampoRelatorioController()
        {
            CamposRelatorios = new List<CampoRelatorio>();
            CamposRelatorios.Add(new CampoRelatorio
            { 
                RelatoID = 1,
                CampoID = 1,
                Usuario = "Carlos",
                Status = 1,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now
             
            });

            CamposRelatorios.Add(new CampoRelatorio
            {
                RelatoID = 2,
                CampoID = 2,
                Usuario = "Gabriel",
                Status = 2,
                CriadoEm = DateTime.Now,
                AtualizadoEm = DateTime.Now

             });
            CamposRelatorios.Add(new CampoRelatorio
            {
                RelatoID = 3,
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
    }
}