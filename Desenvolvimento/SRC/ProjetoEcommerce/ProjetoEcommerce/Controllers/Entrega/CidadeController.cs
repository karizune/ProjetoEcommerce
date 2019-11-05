using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class CidadeController : Controller
    {
        private readonly ProjetoEcommerceContext _dbContext;
        public CidadeController()
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
        public ActionResult Adicionar(Cidade cidade)
        {
            _dbContext.cidade.Add(cidade);
            return RedirectToAction("ListarTodos");
        }
    }
}