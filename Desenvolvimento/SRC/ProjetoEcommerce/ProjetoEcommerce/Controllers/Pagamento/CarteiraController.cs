using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    
    public class CarteiraController : Controller
    {
        ICarteiraService _service = new CarteiraService();
        
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
        public ActionResult Detalhes(int id)
        {
            Carteira resultado = _service.Get(id);
            return View(resultado);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Carteira obj)
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
        public ActionResult Editar(Carteira obj)
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