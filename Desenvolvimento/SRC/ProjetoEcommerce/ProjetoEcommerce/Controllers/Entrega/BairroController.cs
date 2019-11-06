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
    public class BairroController : Controller
    {
        private readonly BairroService _dbContext;
        public BairroController()
        {
            _dbContext = new BairroService();
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
        public ActionResult Adicionar(Bairro bairro)
        {
            _dbContext.Save(bairro);
            return RedirectToAction("ListarTodos");
        }
    }
}
