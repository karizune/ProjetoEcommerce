using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class BandeiraCartaoController : Controller
    {
        //private readonly IBandeiraCartaoService _bandeiraCartaoService;

        BandeiraCartaoService _bandeiraCartaoService = new BandeiraCartaoService(new BandeiraCartaoRepository());
        //public BandeiraCartaoController(IBandeiraCartaoService bandeiraCartaoService)
        //{
        //    _bandeiraCartaoService = bandeiraCartaoService;
        //}
        public ActionResult Index()
        {
            return View(_bandeiraCartaoService.GetAll());
        }
        public ActionResult Detalhes(int id)
        {
            var ent = _bandeiraCartaoService.Get(id);
            return View(ent);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(BandeiraCartao ent)
        {
            _bandeiraCartaoService.Add(ent);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            var ent = _bandeiraCartaoService.Get(id);
            return View(ent);
        }
        [HttpPost]
        public ActionResult Editar(BandeiraCartao bandeiraCartao)
        {
            _bandeiraCartaoService.Update(bandeiraCartao);

            return RedirectToAction("Index");
        }
        public ActionResult Excluir(int id)
        {
            _bandeiraCartaoService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}