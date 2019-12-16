using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Pagamento.Controllers.Pagamento
{
    public class TipoCartaoController : Controller
    {
        ITipoCartaoService _service = new TipoCartaoService();
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
        public ActionResult Detalhes(int id)
        {
            TipoCartao resultado = _service.Get(id);
            return View(resultado);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(TipoCartao obj)
        {
            _service.Add(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            var resultado = _service.Get(id);
            return View(resultado);
        }
        [HttpPost]
        public ActionResult Editar(TipoCartao obj)
        {
            _service.Update(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Excluir(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }


    }
}