using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FeedbackParceiroController : Controller
    {
        private readonly IFeedbackParceiroService _feedbackParceiroService;
        private readonly IParceiroService _parceiroService;
        private readonly IUsuarioService _usuarioService;

        //List<Usuario> usuarios = new List<Usuario>();
        public FeedbackParceiroController(IFeedbackParceiroService feedbackParceiroService, IParceiroService parceiroService, IUsuarioService usuarioService)
        {
            _feedbackParceiroService = feedbackParceiroService;
            _parceiroService = parceiroService;
            _usuarioService = usuarioService;
            //usuarios.Add(new Usuario{
            //    IdUsuario = 1,
            //    Nome = "Vit1 Kuza1"
            //});
            //usuarios.Add(new Usuario{
            //    IdUsuario = 2,
            //    Nome = "Vts Kuza1zinho"
            //});
        }
        public ActionResult Index(string usuario)
        {
            var usuarioLogado = 1;
            IEnumerable<FeedbackParceiro> ent;

            if (string.IsNullOrEmpty(usuario))
                ent = _feedbackParceiroService.GetFeedbacksAtivosPorUsuario(usuarioLogado);
            else
                ent = _feedbackParceiroService.GetAtivosPorNomeUsuario(usuario).ToList();

            var mapped = MapperHelper.Container().Map<IEnumerable<FeedbackParceiro>, IEnumerable<FeedbackParceiroViewModel>>(ent);

            return View(mapped);
        }

        [HttpPost]
        public ActionResult UsuariosList(string usuario)
        {
            var ent = _feedbackParceiroService.GetAtivosPorNomeUsuario(usuario).ToList();

            return Json(new { usuarios = ent });
        }

        [HttpPost]
        public ActionResult PegarUsuariosAtivos()
        {
            var ent = _usuarioService.GetAll().Select(f => f.Nome);
            return Json(ent);
        }

        // GET: FeedbackParceiro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FeedbackParceiro/Create
        public ActionResult Create()
        {
            var ent = new FeedbackParceiroViewModel();
            ent.Usuarios = _usuarioService.GetAll();
            ent.Parceiros = _parceiroService.GetAll();
            return View(ent);
        }

        // POST: FeedbackParceiro/Create
        [HttpPost]
        public ActionResult Create(FeedbackParceiroViewModel ent)
        {
            try
            {

                //var mapped = new FeedbackParceiro
                //{
                //    DataCadastro = ent.DataCadastro,
                //    Descricao = ent.Descricao,
                //    Estrelas = ent.Estrelas,
                //    IdFeedbackParceiro = ent.IdFeedbackParceiro,
                //    IdParceiro = ent.IdParceiro,
                //    IdUsuario = ent.IdUsuario,
                //    Parceiro = ent.Parceiro,
                //    Usuario = ent.Usuario
                //};
                var mapped = MapperHelper.Container().Map<FeedbackParceiroViewModel, FeedbackParceiro>(ent);
                _feedbackParceiroService.Add(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackParceiro/Edit/5
        public ActionResult Edit(int id)
        {
            //var ent = _feedbackParceiroService.GetOneBy(id);
            return View();
        }

        // POST: FeedbackParceiro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackParceiro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FeedbackParceiro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
