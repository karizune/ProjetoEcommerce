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

        [HttpDelete]
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Atualiza()
        {
            return View();
        }

        [HttpPut]
        public ActionResult Atualizar(Endereco endereco)
        {
            _dbContext.Update(endereco);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Buscar(int id)
        {
            Endereco obj = _dbContext.GetOne(id);
            return View(obj);
        }
    }
}