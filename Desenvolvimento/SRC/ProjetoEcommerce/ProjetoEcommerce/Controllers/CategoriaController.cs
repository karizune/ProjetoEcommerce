using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService categoriaService;

        public CategoriaController()
        {
            categoriaService = new CategoriaService();
        }

        public ActionResult Index()
        {
            return View();
        }
        // GET: Categoria
        public ActionResult ListarTodas()
        {
            var categorias = categoriaService.BuscarAtivos();
            return View(categorias);
        }
        
        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Categoria ent)
        {
            ent.Status = 1;
            ent.Usuario = "grupo4";
            categoriaService.Salvar(ent);

            return Redirect("ListarTodas");
        }
        public ActionResult Atualizar(int id)
        {
            return Redirect("ListarTodas");
        }
        public ActionResult Excluir(int id)
        {
            categoriaService.Excluir(id, "teste");
            return Redirect("ListarTodas");
        }
    }
}