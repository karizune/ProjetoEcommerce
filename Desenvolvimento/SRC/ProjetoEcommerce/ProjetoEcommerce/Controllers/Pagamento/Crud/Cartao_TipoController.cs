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
    public class Cartao_TipoController : Controller
    {
        // GET: Cartao_Tipo
        ICartao_TipoService _service = new Cartao_TipoService();

        public ActionResult Index()
        {

            return View(_service.GetAll());
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Cartao_Tipo obj)
        {
            _service.Add(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int CartaoID, int TipoCartaoID)
        {

            return View(_service.Get(CartaoID,TipoCartaoID));
        }
        [HttpPost]
        public ActionResult Editar(Cartao_Tipo obj)
        {
            _service.Update(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int CartaoID, int TipoCartaoID)
        {
            _service.Delete(CartaoID, TipoCartaoID);
            return RedirectToAction("Index");
        }
        public ActionResult Detalhes(int CartaoID, int TipoCartaoID)
        {
            Cartao_Tipo resultado = _service.Get(CartaoID, TipoCartaoID);
            return View(resultado);
        }
    }
}