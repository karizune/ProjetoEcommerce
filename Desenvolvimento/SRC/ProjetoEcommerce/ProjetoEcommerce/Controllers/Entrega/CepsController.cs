using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class CepsController : Controller
    {
        private readonly ProjetoEcommerceContext _dbContext;
        public CepsController()
        {
            _dbContext = new ProjetoEcommerceContext();
        }

        public ActionResult ListarTodos()
        {
            var lista = _dbContext.ceps.ToList();
            return View(lista);
        }

        
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Ceps cep)
        {
            _dbContext.ceps.Add(cep);
            return RedirectToAction("ListarTodos");
        }
    }
}