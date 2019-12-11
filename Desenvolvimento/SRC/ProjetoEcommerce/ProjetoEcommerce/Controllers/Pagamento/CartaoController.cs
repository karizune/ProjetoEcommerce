﻿using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class CartaoController : Controller
    {
        ProjetoEcommerceContext context = new ProjetoEcommerceContext();
        ICartaoService _service;
        public CartaoController(ICartaoService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {

            return RedirectToAction("ListarTodos");
        }
        public ActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(Cartao cartao)
        {
            context.Cartao.Add(cartao);
            cartao.Status = 1;
            cartao.Usuario = "Sistema";
            cartao.AtualizadoEm = DateTime.Now;
            cartao.CriadoEm = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ListarTodos()
        {
            return View(context.Cartao.ToList());
        }
        public ActionResult Editar(int id)
        {
            Cartao resultado = context.Cartao.First(c => c.CartaoID == id);
            return View(resultado);
        }


        public ActionResult Remover(int id)
        {
            Cartao obj = context.Cartao.First(c => c.CartaoID == id);
            obj.AtualizadoEm = DateTime.Now;
            obj.Status = 0;
            obj.Usuario = "Sistema";
            context.Cartao.Attach(obj);
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListarTodos");
        }

    }
}