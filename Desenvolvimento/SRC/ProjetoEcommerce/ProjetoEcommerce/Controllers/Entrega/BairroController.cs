using ProjetoEcommerce.Data.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class BairroController : Controller
    {
        // GET: Bairro
        public ActionResult ListarTodos()
        {
            var context = new ProjetoEcommerceContext();
            var lista = context.bairro.ToList();
     
            return View(lista);
        }
    }
}