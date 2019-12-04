using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class ImagemController : Controller
    {
        private readonly IImagemService imagemService;

        public ImagemController()
        {
            imagemService = new ImagemService();
        }

        public ActionResult Index()
        {
            return View();
        }
        // GET: Imagem
        public ActionResult ListarTodas()
        {
            var imagens = imagemService.BuscarAtivos();
            return View(imagens);
        }

        [HttpGet]

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirConfirm(Imagem ent)
        {
            ent.Status = 1;
            ent.Usuario = "grupo4";
            imagemService.Salvar(ent);

            return Redirect("ListarTodas");
        }
        public ActionResult Atualizar(int id)
        {

            return Redirect("ListarTodas");
        }
        public ActionResult Excluir(int id)
        {
            imagemService.Excluir(id, "teste");
            return Redirect("ListarTodas");
        }
    }
}