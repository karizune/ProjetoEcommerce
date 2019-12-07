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
    public class MarcaController : Controller
    {
        private readonly IMarcaService marcaService;

        public MarcaController()
        {
            marcaService = new MarcaService();
        }

        public ActionResult Index()
        {
            return View(marcaService.BuscarAtivos());
        }
        // GET: Marca
        public ActionResult ListarTodas()
        {
            var marcas = marcaService.BuscarAtivos();
            return View(marcas);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Marca ent)
        {
            ent.Status = 1;
            ent.Usuario = "grupo4";
            marcaService.Salvar(ent);

            return RedirectToAction("Index");
        }
        public ActionResult Atualizar(int id)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Excluir(int id)
        {
            marcaService.Excluir(id, "marciel");
            return RedirectToAction("Index");
        }
    }
}