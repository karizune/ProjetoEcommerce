using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class EstadoController : Controller
    {
        private readonly ProjetoEcommerceContext _dbContext;
        public EstadoController()
        {
            _dbContext = new ProjetoEcommerceContext();
        }
        public ActionResult ListarTodos()
        {
            var lista = _dbContext.estado.ToList();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Estado estado)
        {
            _dbContext.estado.Add(estado);
            return RedirectToAction("ListarTodos");
        }
    }
}