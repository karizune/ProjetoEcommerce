using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class EnderecoController : Controller
    {
        private readonly EnderecoService _dbContext;
        public EnderecoController()
        {
            _dbContext = new EnderecoService();
        }
        public ActionResult ListarTodos()
        {
            var lista = _dbContext.GetAll();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Endereco endereco)
        {
            _dbContext.Save(endereco);
            return RedirectToAction("ListarTodos");
        }
    }
}