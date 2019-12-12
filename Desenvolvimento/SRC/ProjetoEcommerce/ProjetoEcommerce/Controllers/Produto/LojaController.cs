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
    public class LojaController : Controller
    {
        private readonly ILojaService lojaService;

        public LojaController()
        {
            lojaService = new LojaService();
        }

        public ActionResult Index()
        {
            return View(lojaService.BuscarAtivos());
        }
        // GET: loja
        public ActionResult ListarTodas()
        {
            var lojas = lojaService.BuscarAtivos();
            return View(lojas);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Loja ent)
        {
            ent.Status = 1;
            ent.Usuario = "Marciel";
            lojaService.Salvar(ent);

            return RedirectToAction("Index");
        }
        public ActionResult Atualizar(int id)
        {
            var entidade = lojaService.GetOneBy(id);
            return View("Incluir", entidade);
        }
        public ActionResult Excluir(int id)
        {
            lojaService.Excluir(id, "Marciel");
            return RedirectToAction("Index");
        }
    }
}