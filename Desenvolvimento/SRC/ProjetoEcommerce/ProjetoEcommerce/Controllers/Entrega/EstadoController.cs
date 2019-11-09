using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class EstadoController : Controller
    {
        private readonly EstadoService _dbContext;

        public EstadoController()
        {
            _dbContext = new EstadoService();
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
        public ActionResult Adicionar(Estado estado)
        {
            _dbContext.Save(estado);
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
        public ActionResult Atualizar(Estado estado)
        {
            _dbContext.Update(estado);
            return RedirectToAction("ListarTodos");
        }

        public ActionResult Buscar(int id)
        {
            Estado obj = _dbContext.GetOne(id);
            return View(obj);
        }
    }
}