using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Services.Produto;
using ProjetoEcommerce.Service.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IMarcaService marcaService;

        public MarcaController()
        {
            marcaService = new MarcaService();
        }

        public ActionResult Index()
        {
            return View();
        }
        // GET: Marca
        public ActionResult ListarTodas()
        {
            var marcas = marcaService.BuscarAtivos();
            return View(marcas);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Marca ent)
        {
            ent.Status = 1;
            ent.Usuario = "grupo4";
            marcaService.Salvar(ent);

            return Redirect("ListarTodas");
        }
        public ActionResult Atualizar(int id)
        {
            return Redirect("ListarTodas");
        }
        public ActionResult Excluir(int id)
        {
            marcaService.Excluir(id, "teste");
            return Redirect("ListarTodas");
        }
    }
}