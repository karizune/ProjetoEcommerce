using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class TipoCartaoController : Controller
    {
        private static List<TipoCartao> TiposCartoes { get; set; }

        public TipoCartaoController()
        {
            TiposCartoes = new List<TipoCartao>();
            TiposCartoes.Add(new TipoCartao
            {
                TipoCartaoID = 1,
                Descricao = "CRÉDITO", 
                Status = 1,
                CriadoEm = DateTime.Now
            });
            TiposCartoes.Add(new TipoCartao
            {
                TipoCartaoID = 2,
                Descricao = "DÉBITO",
                Status = 1,
                CriadoEm = DateTime.Now
            });
            TiposCartoes.Add(new TipoCartao
            {
                TipoCartaoID = 3,
                Descricao = "VALE ALIMENTAÇÃO",
                Status = 0,
                CriadoEm = DateTime.Now
            });
        }

        // GET: TipoCartao
        public ActionResult ListarTodos()
        {
            return View(TiposCartoes);
        }
    }
}