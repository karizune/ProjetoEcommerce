using ProjetoEcommerce.Data.EntityFramework.Context;
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
    public class PagamentoController : Controller
    {
        IPagamentoService _service = new PagamentoService();

        public ActionResult Index()
        {

            return View(_service.GetAll());
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Dominio.Entidades.Pagamento.Pagamento cartao)
        {
            _service.Add(cartao);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {

            return View(_service.Get(id));
        }
        [HttpPost]
        public ActionResult Editar(Dominio.Entidades.Pagamento.Pagamento obj)
        {
            _service.Update(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Detalhes(int id)
        {
            Dominio.Entidades.Pagamento.Pagamento resultado = _service.Get(id);
            return View(resultado);
        }
    }
}