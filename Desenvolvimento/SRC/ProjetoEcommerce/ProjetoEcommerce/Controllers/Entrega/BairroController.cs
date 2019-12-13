using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Servico.Entrega;
using ProjetoEcommerce.ViewModels;
using System;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Entrega
{
    public class BairroController : Controller
    {
        private readonly BairroService _dbContext;
        private readonly CidadeService _dbCidadeContext;

        public BairroController()
        {
            _dbContext = new BairroService();
            _dbCidadeContext = new CidadeService();
        }

        public ActionResult ListarTodos()
        {
            var lista = _dbContext.GetAll();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            BairroViewModel ent = new BairroViewModel();
            ent.Cidades = _dbCidadeContext.GetAll();
            return View(ent);
        }

        [HttpPost]
        public ActionResult Adicionar(BairroViewModel bairro)
        {
            var mapped = new Bairro
            {
                CidadeID = bairro.CidadeID,
                Nome = bairro.Nome,
                BairroID = bairro.BairroID,
            };

            mapped.CriadoEm = DateTime.Now;
            mapped.AtualizaEm = DateTime.Now;
            mapped.Usuario = "Abner";
            mapped.Status = true;
            _dbContext.Save(mapped);
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
            Bairro obj = _dbContext.GetOne(id);
            return View(obj);

        }
    }
}