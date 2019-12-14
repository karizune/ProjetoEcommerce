using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class RastreioController : Controller
    {
        private readonly IRastreioService _rastreioService;

        public RastreioController(IRastreioService rastreioService)
        {
            _rastreioService = rastreioService;
        }

        // GET: Rastreio
        public ActionResult Index()
        {
            var ent = _rastreioService.GetAll();
            var mapped = MapperHelper.Container().Map<IEnumerable<Rastreio>, IEnumerable<RastreioViewModel>>(ent);

            return View(mapped);
        }

        // GET: Rastreio/Details/5
        public ActionResult Details(int id)
        {
            var ent = _rastreioService.GetOneBy(f => f.IdRastreio == id);
            var mapped = MapperHelper.Container().Map<Rastreio, RastreioViewModel>(ent);
            
            return View(mapped);
        }

        // GET: Rastreio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rastreio/Create
        [HttpPost]
        public ActionResult Create(RastreioViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<RastreioViewModel, Rastreio>(ent);
                _rastreioService.Add(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rastreio/Edit/5
        public ActionResult Edit(int id)
        {
            var ent = _rastreioService.GetOneBy(f => f.IdRastreio == id);
            var mapped = MapperHelper.Container().Map<Rastreio, RastreioViewModel>(ent);

            return View(mapped);
        }

        // POST: Rastreio/Edit/5
        [HttpPost]
        public ActionResult EditConfirm(int id)
        {
            try
            {
                var ent = _rastreioService.GetOneBy(f => f.IdRastreio == id);
                _rastreioService.Update(ent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rastreio/Delete/5
        public ActionResult Delete(int id)
        {
            var ent = _rastreioService.GetOneBy(f => f.IdRastreio == id);
            var mapped = MapperHelper.Container().Map<Rastreio, RastreioViewModel>(ent);

            return View(mapped);
        }

        // POST: Rastreio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RastreioViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<RastreioViewModel, Rastreio>(ent);
                _rastreioService.Delete(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
