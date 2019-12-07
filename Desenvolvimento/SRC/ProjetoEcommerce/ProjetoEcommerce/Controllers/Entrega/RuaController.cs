using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
using System;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class RuaController : Controller
    {
        private readonly RuaService _dbContext;

        public RuaController()
        {
            _dbContext = new RuaService();
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
        public ActionResult Adicionar(Rua rua)
        {
            rua.CriadoEm = DateTime.Now;
            rua.AtualizaEm = DateTime.Now;
            _dbContext.Save(rua);
            return RedirectToAction("ListarTodos");
        }

        [HttpDelete]
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Atualizar()
        {
            return View();
        }

        [HttpPut]
        public ActionResult Atualizar(Rua rua)
        {
            rua.AtualizaEm = DateTime.Now;
            _dbContext.Update(rua);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Buscar(int id)
        {
            Rua obj = _dbContext.GetOne(id);
            return View(obj);
        }
    }
}