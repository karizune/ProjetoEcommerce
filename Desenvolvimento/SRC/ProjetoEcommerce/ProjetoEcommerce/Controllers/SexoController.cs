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
    public class SexoController : Controller
    {
        private readonly ISexoService _sexoService;

        public SexoController(ISexoService sexoService)
        {
            _sexoService = sexoService;
        }
        // GET: Sexo
        public ActionResult Index()
        {
            var sexoViewModel = Mapper.Map<IEnumerable<Sexo>, IEnumerable<SexoViewModel>>(_sexoService.GetAll());
            return View(sexoViewModel);
        }

        // GET: Sexo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sexo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sexo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SexoViewModel sexo)
        {
            if (ModelState.IsValid)
            {
                var sexoDomain = Mapper.Map<SexoViewModel, Sexo>(sexo);
                _sexoService.Add(sexoDomain);

                return RedirectToAction("Index");
            }

            return View(sexo);
        }

        // GET: Sexo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sexo/Edit/5
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

        // GET: Sexo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sexo/Delete/5
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
