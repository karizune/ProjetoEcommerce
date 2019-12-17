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

        public FeedbackParceiroController(IFeedbackParceiroService feedbackParceiroService, IParceiroService parceiroService, IUsuarioService usuarioService)
        {
            _feedbackParceiroService = feedbackParceiroService;
            _parceiroService = parceiroService;
            _usuarioService = usuarioService;
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
            var ent = _feedbackParceiroService.GetOneBy(f => f.IdFeedbackParceiro == id);
            var mapped = MapperHelper.Container().Map<FeedbackParceiro, FeedbackParceiroViewModel>(ent);

            return View(mapped);
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
                var mapped = MapperHelper.Container().Map<FeedbackParceiroViewModel, FeedbackParceiro>(ent);
                _feedbackParceiroService.Add(mapped);

                return View("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: FeedbackParceiro/Edit/5
        public ActionResult Edit(int id)
        {
            var ent = _feedbackParceiroService.GetOneBy(f => f.IdFeedbackParceiro == id);
            var mapped = MapperHelper.Container().Map<FeedbackParceiro, FeedbackParceiroViewModel>(ent);
            mapped.Parceiros = _parceiroService.GetAll();

            return View(mapped);
        }

        // POST: FeedbackParceiro/Edit/5
        [HttpPost]
        public ActionResult Edit(FeedbackParceiroViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<FeedbackParceiroViewModel, FeedbackParceiro>(ent);
                _feedbackParceiroService.Update(mapped);

                return View("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: FeedbackParceiro/Delete/5
        public ActionResult Delete(int id)
        {
            var ent = _feedbackParceiroService.GetOneBy(f => f.IdFeedbackParceiro == id);
            var mapped = MapperHelper.Container().Map<FeedbackParceiro, FeedbackParceiroViewModel>(ent);
            return View(mapped);
        }

        // POST: FeedbackParceiro/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirm(int id, FormCollection collection)
        {
            try
            {
                var ent = _feedbackParceiroService.GetOneBy(f => f.IdFeedbackParceiro == id);
                _feedbackParceiroService.Delete(ent);
                    
                return View("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
