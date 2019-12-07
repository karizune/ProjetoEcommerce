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
            ent.Usuario = "grupo4";
            lojaService.Salvar(ent);

            return Redirect("Index");
        }
        public ActionResult Atualizar(int id)
        {

            return Redirect("Index");
        }
        public ActionResult Excluir(int id)
        {
            lojaService.Excluir(id, "marciel");
            return Redirect("Index");
        }
    }
}