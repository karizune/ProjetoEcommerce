using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
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
        [HttpDelete]
        public ActionResult Deletar(int id, string usuario)
        {
            _dbContext.Delete(id, usuario);
            return RedirectToAction("ListarTodos");
        }

        [HttpPut]
        public ActionResult Atualizar(Bairro obj)
        {
            _dbContext.Update(obj);
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Atualizar()
        {
            return View();
        }
        public ActionResult Buscar(int id)
        {
            Bairro obj = _dbContext.GetOne(id);
            return View(obj);

        }
    }
}