using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
using System;
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
            cep.CriadoEm = DateTime.Now;
            cep.AtualizaEm = DateTime.Now;
            _dbContext.Save(cep);
            return RedirectToAction("ListarTodos");
        }
        [HttpDelete]
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }
        [HttpPut]
        public ActionResult Atualizar(Ceps obj)
        {
            obj.AtualizaEm = DateTime.Now;
            _dbContext.Update(obj);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Atualizar()
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