using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class BandeiraCartaoController : Controller
    {
        private readonly IBandeiraCartaoService _bandeiraCartaoService;

        public BandeiraCartaoController(IBandeiraCartaoService bandeiraCartaoService)
        {
            _bandeiraCartaoService = bandeiraCartaoService;
        }

        [Route("ListarTodos")]
        public ActionResult Index()
        {
            var ent = _bandeiraCartaoService.GetAll();

            return View("ListarTodos", ent);
        }

        
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(BandeiraCartao ent)
        {
            _bandeiraCartaoService.Add(ent);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Excluir(int id)
        {
            _bandeiraCartaoService.Delete(id);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Editar(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar(BandeiraCartao bandeiraCartao)
        {
            _bandeiraCartaoService.Update(bandeiraCartao);

            return View();
        }
    }
}