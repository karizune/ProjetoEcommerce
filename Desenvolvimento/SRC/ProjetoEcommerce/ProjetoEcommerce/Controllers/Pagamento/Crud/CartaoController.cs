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
    public class CartaoController : Controller
    {
        
        ICartaoService _service = new CartaoService();
        
        public ActionResult Index()
        {

            return View(_service.GetAll());
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Cartao cartao)
        {
            _service.Add(cartao);
            return RedirectToAction("Index");
        }
        
        public ActionResult Editar(int id)
        {

            return View(_service.Get(id));
        }
        [HttpPost]
        public ActionResult Editar(Cartao obj)
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
            Cartao resultado = _service.Get(id);
            return View(resultado);
        }
        /*
        public ActionResult Reativar(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        */

    }
}