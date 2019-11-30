using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class JuridicoController : Controller
    {
        private readonly IJuridicoService _juridicoService;

        public JuridicoController(IJuridicoService juridicoService)
        {
            _juridicoService = juridicoService;
        }
        // GET: Juridico
        public ActionResult Index()
        {
            var juridicoViewModel = AutoMapperConfig.Mapper.Map<IEnumerable<Juridico>, IEnumerable<JuridicoViewModel>>(_juridicoService.GetAll());
            return View(juridicoViewModel);
        }

        // GET: Juridico/Details/5
        public ActionResult Details(int id)
        {
            var juridico = _juridicoService.GetById(id);
            var juridicoViewModel = AutoMapperConfig.Mapper.Map<Juridico, JuridicoViewModel>(juridico);
            return View(juridicoViewModel);
        }

        // GET: Juridico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juridico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JuridicoViewModel juridico)
        {
            if (ModelState.IsValid)
            {
                var juridicoDomain = AutoMapperConfig.Mapper.Map<JuridicoViewModel, Juridico>(juridico);
                _juridicoService.Add(juridicoDomain);

                return RedirectToAction("Index");
            }

            return View(juridico);
        }

        // GET: Juridico/Edit/5
        public ActionResult Edit(int id)
        {
            var juridico = _juridicoService.GetById(id);
            var juridicoViewModel = AutoMapperConfig.Mapper.Map<Juridico, JuridicoViewModel>(juridico);
            return View(juridicoViewModel);
        }

        // POST: Juridico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JuridicoViewModel juridico)
        {
            if (ModelState.IsValid)
            {
                var juridicoDomain = AutoMapperConfig.Mapper.Map<JuridicoViewModel, Juridico>(juridico);
                _juridicoService.Update(juridicoDomain);

                return RedirectToAction("Index");
            }
            return View(juridico);
        }

        // GET: Juridico/Delete/5
        public ActionResult Delete(int id)
        {
            var juridico = _juridicoService.GetById(id);
            var juridicoViewModel = AutoMapperConfig.Mapper.Map<Juridico, JuridicoViewModel>(juridico);
            return View(juridicoViewModel);
        }

        // POST: Juridico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var juridico = _juridicoService.GetById(id);
            _juridicoService.Remove(juridico);

            return RedirectToAction("Index");
        }
    }
}
