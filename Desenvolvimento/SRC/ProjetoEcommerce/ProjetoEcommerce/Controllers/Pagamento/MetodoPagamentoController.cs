using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class MetodoPagamentoController : Controller
    {
        List<MetodoPagamento> metodosPagamento = new List<MetodoPagamento>()
        {
            new MetodoPagamento
            {
                MetodoPagamentoID=1,Descricao="Drédito"
            },
            new MetodoPagamento
            {
                MetodoPagamentoID=2,Descricao="Crébito"
            }
        };
        public ActionResult Index()
        {
            return RedirectToAction("ListarTodos");
        }
        public ActionResult ListarTodos()
        {
            return View(metodosPagamento);
        }
    }
}