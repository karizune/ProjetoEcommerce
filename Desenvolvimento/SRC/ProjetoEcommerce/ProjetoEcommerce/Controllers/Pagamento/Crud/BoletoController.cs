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
    public class BoletoController : Controller
    {
        IBoletoService _service = new BoletoService();

        public ActionResult Index()
        {

            return View(_service.GetAll());
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Boleto cartao)
        {
            _service.Add(cartao);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {

            return View(_service.Get(id));
        }
        [HttpPost]
        public ActionResult Editar(Boleto obj)
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
            Boleto resultado = _service.Get(id);
            return View(resultado);
        }
        
    }
}