using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class UsuarioPagamentoController : Controller
    {
        // GET: UsuarioPagamento
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Pagar(Usuario usuario)
        {
            return View();
        }
    }
}