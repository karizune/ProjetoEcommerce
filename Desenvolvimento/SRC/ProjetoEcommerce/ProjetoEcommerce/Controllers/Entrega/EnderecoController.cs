using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class EnderecoController : Controller
    {
        private readonly ProjetoEcommerceContext _dbContext;
        public EnderecoController()
        {
            _dbContext = new ProjetoEcommerceContext();
        }
        public ActionResult ListarTodos()
        {
            var lista = _dbContext.endereco.ToList();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Endereco cidade)
        {
            _dbContext.endereco.Add(cidade);
            return RedirectToAction("ListarTodos");
        }
    }
}