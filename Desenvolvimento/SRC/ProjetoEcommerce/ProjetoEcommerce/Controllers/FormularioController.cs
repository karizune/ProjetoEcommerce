﻿using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FormularioController : Controller
    {
        //Formulario form = new Formulario();
        private readonly ProjetoEcommerceContext db;

        private readonly IFormularioRepository _formularioRepository;

        public FormularioController()
        {
            _formularioRepository = new FormularioRepository();
            db = new ProjetoEcommerceContext();
        }

        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTodos()
        {
            var ListFormulario= db.Formulario
                 .Where(f => f.Status == 1);


            return View(ListFormulario);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Formulario form)
        {
            //var db = new ProjetoEcommerceContext();

            form.Usuario = "Adriano";
            form.Status = 1;
            form.CriadoEm = DateTime.Now;
            form.AtualizadoEm = DateTime.Now;
            db.Formulario.Add(form);
            db.SaveChanges();
            
            return Redirect("ListarTodos");            
        }

        public ActionResult Delete(int id)
        {
            var ent = db.Formulario.Find(id);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "deleteeeeeeeeee carai";
            db.Entry<Formulario>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListarTodos");
        }
    }
}
