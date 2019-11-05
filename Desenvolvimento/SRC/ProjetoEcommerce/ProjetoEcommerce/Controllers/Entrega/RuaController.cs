using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class RuaController : Controller
    {
        private readonly ProjetoEcommerceContext _dbContext;
        public RuaController()
        {
            _dbContext = new ProjetoEcommerceContext();
        }
        public ActionResult ListarTodos()
        {
            var lista = _dbContext.cidade.ToList();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Rua rua)
        {
            _dbContext.rua.Add(rua);
            return RedirectToAction("ListarTodos");
        }
    }
}