using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult ListarTodas()
        {
            return View();
        }
    }
}