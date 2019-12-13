using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FisicoController : Controller
    {
        private readonly ISexoService _sexoService;
        private readonly IFisicoService _fisicoService;

        public FisicoController(IFisicoService fisicoService, ISexoService sexoService)
        {
            _sexoService = sexoService;
            _fisicoService = fisicoService;
        }
        // GET: Fisico
        public ActionResult Index()
        {

            var fisicolViewModel = AutoMapperConfig.Mapper.Map<IEnumerable<Fisico>, IEnumerable<FisicoViewModel>>(_fisicoService.GetAll());
            return View(fisicolViewModel);
        }

        // GET: Fisico/Details/5
        public ActionResult Details(int id)
        {
            var fisico = _fisicoService.GetById(id);
            var fisicoViewModel = AutoMapperConfig.Mapper.Map<Fisico, FisicoViewModel>(fisico);
            return View(fisicoViewModel);
        }

        // GET: Fisico/Create
        public ActionResult Create()
        {
            var ent = new FisicoViewModel
            {
                Sexos = AutoMapperConfig.Mapper.Map<IEnumerable<Sexo>, IEnumerable<SexoViewModel>>(_sexoService.BuscarAtivos())
        };
            return View(ent);
        }

        // POST: Fisico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FisicoViewModel fisico)
        {

            ModelState.Remove("Tipo");

            if (ModelState.IsValid)
            {
                var fisicoDomain = AutoMapperConfig.Mapper.Map<FisicoViewModel, Fisico>(fisico);
                fisicoDomain.Status = true;
                fisicoDomain.Usuario = "renato";
                _fisicoService.Salvar(fisicoDomain);

                return RedirectToAction("Index");
            }


            return View(fisico);
        }


        // GET: Fisico/Edit/5
        public ActionResult Edit(int id)
        {
            var fisico = _fisicoService.GetById(id);
            var fisicoViewModel = AutoMapperConfig.Mapper.Map<Fisico, FisicoViewModel>(fisico);
            return View(fisicoViewModel);
        }

        // POST: Fisico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FisicoViewModel fisico)
        {
            if (ModelState.IsValid)
            {
                var fisicoDomain = AutoMapperConfig.Mapper.Map<FisicoViewModel, Fisico>(fisico);
                _fisicoService.Salvar(fisicoDomain);

                return RedirectToAction("Index");
            }
            return View(fisico);
        }

        // GET: Fisico/Delete/5
        public ActionResult Delete(int id)
        {
            var fisico = _fisicoService.GetById(id);
            var fisicoViewModel = AutoMapperConfig.Mapper.Map<Fisico, FisicoViewModel>(fisico);
            return View(fisicoViewModel);
        }

        // POST: Fisico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fisico = _fisicoService.GetById(id);
            _fisicoService.Remove(fisico);

            return RedirectToAction("Index");
        }
    }
}
