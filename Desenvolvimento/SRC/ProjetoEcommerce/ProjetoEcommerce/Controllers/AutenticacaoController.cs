using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao
        public ActionResult Entrar()
        {
            return View();
        }

        public ActionResult Sair()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EntrarConfirm()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}