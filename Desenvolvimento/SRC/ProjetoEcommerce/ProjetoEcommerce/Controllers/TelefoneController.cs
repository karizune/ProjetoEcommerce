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
    public class TelefoneController : Controller
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneController(ITelefoneService telefoneService)
        {
            _telefoneService = telefoneService;
        }
        // GET: Telefone
        public ActionResult Index()
        {
            var telefoneViewModel = Mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(_telefoneService.GetAll());
            return View(telefoneViewModel);
        }

        // GET: Telefone/Details/5
        public ActionResult Details(int id)
        {
            var telefone = _telefoneService.GetById(id);
            var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefone);

            return View(telefoneViewModel);
        }

        // GET: Telefone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Telefone/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TelefoneViewModel telefone)
        {
            if (ModelState.IsValid)
            {
                var telefoneDomain = Mapper.Map<TelefoneViewModel, Telefone>(telefone);
                _telefoneService.Add(telefoneDomain);

                return RedirectToAction("Index");
            }

            return View(telefone);
        }

        // GET: Telefone/Edit/5
        public ActionResult Edit(int id)
        {
            var telefone = _telefoneService.GetById(id);
            var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefone);

            return View(telefoneViewModel);
        }

        // POST: Telefone/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TelefoneViewModel Telefone)
        {
            if (ModelState.IsValid)
            {
                var telefoneDomain = Mapper.Map<TelefoneViewModel, Telefone>(Telefone);
                _telefoneService.Update(telefoneDomain);

                return RedirectToAction("Index");
            }
            return View(Telefone);
        }


        // GET: Telefone/Delete/5
        public ActionResult Delete(int id)
        {
            var telefone = _telefoneService.GetById(id);
            var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefone);
            return View(telefoneViewModel);
        }

        // POST: Telefone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var telefone = _telefoneService.GetById(id);
            _telefoneService.Remove(telefone);

            return RedirectToAction("Index");
        }
    }
}
