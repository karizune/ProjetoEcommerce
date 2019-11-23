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
            var juridicoViewModel = Mapper.Map<IEnumerable<Juridico>, IEnumerable<JuridicoViewModel>>(_juridicoService.GetAll());
            return View(juridicoViewModel);
        }

        // GET: Juridico/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                var juridicoDomain = Mapper.Map<JuridicoViewModel, Juridico>(juridico);
                _juridicoService.Add(juridicoDomain);

                return RedirectToAction("Index");
            }

            return View(juridico);
        }

        // GET: Juridico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Juridico/Edit/5
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

        // GET: Juridico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Juridico/Delete/5
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
