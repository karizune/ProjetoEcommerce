using Microsoft.AspNetCore.Mvc;
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
            return View();
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
            ent.Usuario = "grupo4";
            produtoService.Salvar(ent);

            return Redirect("ListarTodas");
        }
        public ActionResult Atualizar(int id)
        {
            return Redirect("ListarTodas");
        }
        public ActionResult Excluir(int id)
        {
            produtoService.Excluir(id, "teste");
            return Redirect("ListarTodas");
        }
    }
}