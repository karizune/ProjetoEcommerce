using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class BandeiraCartaoController : Controller
    {
        List<BandeiraCartao> bandeirasCartao = new List<BandeiraCartao>()
        {
            new BandeiraCartao
            {
                BandeiraCartaoID=1,Descricao="Mastercard"
            },
            new BandeiraCartao
            {
                BandeiraCartaoID=2,Descricao="Visa"
            }
        };
        public ActionResult Index()
        {
            return RedirectToAction("ListarTodos");
        }
        public ActionResult ListarTodos()
        {

            return View(bandeirasCartao);
        }
    }
}