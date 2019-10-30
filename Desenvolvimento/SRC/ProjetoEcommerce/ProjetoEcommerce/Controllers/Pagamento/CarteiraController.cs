using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    
    public class CarteiraController : Controller
    {
        List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario
            {
                ID=1,Nome="Nomenclatura Silveira"
            },
            new Usuario
            {
                ID=2,Nome="Nome da Silva"
            }
        };
        List<Carteira> carteiras = new List<Carteira>()
        {
            new Carteira
            {
                CarteiraID = 1, Saldo = 22.34M, UsuarioID = 1,Status=0
            },
            new Carteira
            {
                CarteiraID = 2, UsuarioID = 2, Saldo = 256.34M,Status=1
            }
        };
        public ActionResult Index()
        {
            return RedirectToAction("ListarTodos");
        }
        public ActionResult ListarTodos()
        {
            return View(carteiras);
        }
        public ActionResult Detalhes(int id)
        {
            Carteira resultado = new Carteira();
            foreach (var item in carteiras)
            {
                if(item.CarteiraID == id)
                {
                    resultado = item;
                    break;
                }
            }
            foreach (var item in usuarios)
            {
                if (item.ID == id)
                {
                    resultado.usuario = item;
                }
            }
            return View(resultado);
        }
    }
}