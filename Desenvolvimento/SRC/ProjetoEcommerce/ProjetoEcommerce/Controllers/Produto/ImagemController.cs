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
            return View(imagemService.BuscarAtivos());
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
            if (ent.ImagemArquivo == null)
                throw new Exception("imagem vazia");
            
            var nomeDoArquivo = ent.ImagemArquivo.FileName;

            ent.Status = 1;
            ent.Usuario = "Marciel";
            ent.URL = $@"~/Content/img/{nomeDoArquivo}";
            imagemService.Salvar(ent);

            var nomeDoArquivo_Escrita = $@"{Server.MapPath("~")}Content\img\{nomeDoArquivo}";
            ent.ImagemArquivo.SaveAs(nomeDoArquivo_Escrita);

            return RedirectToAction("Index");
        }
        public ActionResult Atualizar(int id)
        {
            var entidade = imagemService.GetOneBy(id);
            return View("Incluir", entidade);
        }
        public ActionResult Excluir(int id)
        {
            imagemService.Excluir(id, "Marciel");
            return RedirectToAction("Index");
        }
    }
}