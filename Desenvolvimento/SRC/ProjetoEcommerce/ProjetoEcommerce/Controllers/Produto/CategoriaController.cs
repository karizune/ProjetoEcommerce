﻿using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService categoriaService;

        public CategoriaController()
        {
            categoriaService = new CategoriaService();
        }

        public ActionResult Index()
        {
            return View(categoriaService.BuscarAtivos());
        }
        // GET: Categoria
        public ActionResult ListarTodas()
        {
            var categorias = categoriaService.BuscarAtivos();
            return View(categorias);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Categoria ent)
        {
            ent.Status = 1;
            ent.Usuario = "Marciel";
            categoriaService.Salvar(ent);

            return RedirectToAction("Index");
        }
        public ActionResult Atualizar(int id)
        {
            var entidade = categoriaService.GetOneBy(id);
            return View("Incluir", entidade);
        }
        public ActionResult Excluir(int id)
        {
            categoriaService.Excluir(id, "Marciel");
            return RedirectToAction("Index");
        }
    }
}