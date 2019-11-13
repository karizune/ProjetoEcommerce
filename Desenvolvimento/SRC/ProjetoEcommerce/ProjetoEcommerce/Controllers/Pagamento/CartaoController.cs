using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
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
        public ActionResult Index()
        {
        
            return View();
        }
        public ActionResult Criar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Criar(Cartao cartao)
        {
            context.Cartao.Add(cartao);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}