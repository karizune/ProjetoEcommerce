﻿using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult ListarTodos()
        {
            var Usuarios =
                new ProjetoEcommerceContext()
                .Usuario
                .Where(f => f.Status == 1);

            return View(Usuarios);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Usuario ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.UsuarioID = 1;
            //ent.NomeUsuario = "";
            ent.Status = 1;
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.Usuario.Add(ent);
            db.SaveChanges();

            return Redirect("ListarTodos");
        }

        public ActionResult Excluir(int usuarioId)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.Usuario.Find(usuarioId);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.NomeUsuario = "renato";
            db.Entry<Usuario>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("ListarTodos");
        }
    }
}