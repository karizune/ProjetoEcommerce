using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class ParceiroController : Controller
    {
        private readonly IParceiroService _parceiroService;

        public ParceiroController(IParceiroService parceiroService)
        {
            _parceiroService = parceiroService;
        }

        // GET: Parceiro
        public ActionResult Index()
        {
            var ent = _parceiroService.GetAll();
            var mapped = MapperHelper.Container().Map<IEnumerable<Parceiro>, IEnumerable<ParceiroViewModel>>(ent);

            return View(mapped);
        }

        // GET: Parceiro/Details/5
        public ActionResult Details(int id)
        {
            var ent = _parceiroService.GetOneBy(f => f.IdParceiro == id);
            var mapped = MapperHelper.Container().Map<Parceiro, ParceiroViewModel>(ent);

            return View(mapped);
        }

        // GET: Parceiro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parceiro/Create
        [HttpPost]
        public ActionResult Create(ParceiroViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<ParceiroViewModel, Parceiro>(ent);
                _parceiroService.Add(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Parceiro/Edit/5
        public ActionResult Edit(int id)
        {
            var ent = _parceiroService.GetOneBy(f => f.IdParceiro == id);
            var mapped = MapperHelper.Container().Map<Parceiro, ParceiroViewModel>(ent);

            return View(mapped);
        }

        // POST: Parceiro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var ent = _parceiroService.GetOneBy(f => f.IdParceiro == id);
                var mapped = MapperHelper.Container().Map<Parceiro, ParceiroViewModel>(ent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Parceiro/Delete/5
        public ActionResult Delete(int id)
        {
            var ent = _parceiroService.GetOneBy(f => f.IdParceiro == id);
            var mapped = MapperHelper.Container().Map<Parceiro, ParceiroViewModel>(ent);

            return View(mapped);
        }

        // POST: Parceiro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var ent = _parceiroService.GetOneBy(f => f.IdParceiro == id);
                _parceiroService.Delete(ent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
