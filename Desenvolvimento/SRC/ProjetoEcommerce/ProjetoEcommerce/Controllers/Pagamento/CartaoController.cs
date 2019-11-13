using ProjetoEcommerce.Data.EntityFramework.Context;
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
            
            return View(context.Cartao.ToList());
        }
    }
}