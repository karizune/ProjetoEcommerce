using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    
    public class CarteiraController : Controller
    {
        ProjetoEcommerceContext Context = new ProjetoEcommerceContext();
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
        
        public ActionResult Index()
        {
            return RedirectToAction("ListarTodos");
        }
        public ActionResult ListarTodos()
        {

            return View(Context.Carteira.ToList());

            
        }
        public ActionResult Detalhes(int id)
        {
            Carteira resultado = Context.Carteira.First(c => c.CarteiraID == id);
            return View(resultado);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Carteira obj)
        {
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;
            obj.Status = 0;
            obj.Usuario = "Sistema";
            Context.Carteira.Add(obj);
            Context.SaveChanges();
            return RedirectToAction("ListarTodos");
        }
        public ActionResult Deletar(int id)
        {
            Context.Carteira.Remove(Context.Carteira.First(c => c.CarteiraID == id));
            Context.SaveChanges();
            return RedirectToAction("ListarTodos");




        }
    }
}