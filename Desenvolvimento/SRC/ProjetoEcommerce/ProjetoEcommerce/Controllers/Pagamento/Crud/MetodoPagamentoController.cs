using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class MetodoPagamentoController : Controller
    {
        IMetodoPagamentoService _service = new MetodoPagamentoService(); 
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
        public ActionResult Detalhes(int id)
        {
            MetodoPagamento resultado = _service.Get(id);
            return View(resultado);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(MetodoPagamento obj)
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
        public ActionResult Editar(MetodoPagamento obj)
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