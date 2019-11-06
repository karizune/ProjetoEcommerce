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
    public class CidadeController : Controller
    {
        private readonly CidadeService _dbContext;
        public CidadeController()
        {
            _dbContext = new CidadeService();
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
        public ActionResult Adicionar(Cidade cidade)
        {
            _dbContext.Save(cidade);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }
        [HttpPut]
        public ActionResult Atualizar(Cidade obj)
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
            Cidade obj = _dbContext.GetOne(id);
            return View(obj);
        }
    }
}