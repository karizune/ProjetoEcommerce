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
    public class CepsController : Controller
    {
        private readonly CepsService _dbContext;
        public CepsController()
        {
            _dbContext = new CepsService();
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
        public ActionResult Adicionar(Ceps cep)
        {
            _dbContext.Save(cep);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }
        [HttpPut]
        public ActionResult Atualizar(Ceps obj)
        {
            _dbContext.Update(obj);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Atulizar()
        {
            return View();
        }
        public ActionResult Buscar(int id)
        {
            Ceps obj = _dbContext.GetOne(id);
            return View(obj);
        }
    }
}