using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService produtoService;

        public ProdutoController()
        {
            produtoService = new ProdutoService();
        }

        public ActionResult Index()
        {
            return View(produtoService.BuscarAtivos());
        }
        // GET: Produto
        public ActionResult ListarTodas()
        {
            var produtos = produtoService.BuscarAtivos();
            return View(produtos);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Produto ent)
        {
            ent.Status = 1;
            ent.Usuario = "Marciel";
            produtoService.Salvar(ent);

            return RedirectToAction("Index");
        }
        public ActionResult Atualizar(int id)
        {
            var entidade = produtoService.GetOneBy(id);
            return View("Incluir", entidade);
        }
        public ActionResult Excluir(int id)
        {
            produtoService.Excluir(id, "Marciel");
            return RedirectToAction("Index");
        }
    }
}