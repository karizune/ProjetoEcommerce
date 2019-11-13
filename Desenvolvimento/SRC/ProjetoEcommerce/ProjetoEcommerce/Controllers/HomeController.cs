using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Dominio.Interfaces;

namespace ProjetoEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _repositorio;

        public HomeController(IClienteRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lista()
        {
            var clientes = _repositorio.BuscarAtivos();
            return View(clientes);
        }

    }
}