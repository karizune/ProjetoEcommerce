using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoService produtoService;

        public HomeController()
        {
            produtoService = new ProdutoService();
        }
        public ActionResult Index()
        {
            var ent = produtoService.BuscarAtivos().ToList();
            return View(ent);
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
    }
}