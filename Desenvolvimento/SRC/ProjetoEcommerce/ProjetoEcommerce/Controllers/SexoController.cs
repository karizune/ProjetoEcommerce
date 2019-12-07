using AutoMapper;
using ProjetoEcommerce.Data.EntityFramework.Context;
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
            var sexoViewModel = AutoMapperConfig.Mapper.Map<IEnumerable<Sexo>, IEnumerable<SexoViewModel>>(_sexoService.BuscarAtivos());
            return View(sexoViewModel);
        }

        // GET: Sexo/Details/5
        public ActionResult Details(int id)
        {
            var sexo = _sexoService.GetById(id);
            var sexoViewModel = AutoMapperConfig.Mapper.Map<Sexo, SexoViewModel>(sexo);
            return View(sexoViewModel);
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
            //if (ModelState.IsValid)
            //{
                var sexoDomain = AutoMapperConfig.Mapper.Map<SexoViewModel, Sexo>(sexo);
                sexoDomain.Usuario = "askdflas";
                _sexoService.Salvar(sexoDomain);

                return RedirectToAction("Index");
            //}

            //return View(sexo);
        }

        // GET: Sexo/Edit/5
        public ActionResult Edit(int id)
        {
            var sexo = _sexoService.GetById(id);
            var sexoViewModel = AutoMapperConfig.Mapper.Map<Sexo, SexoViewModel>(sexo);
            return View(sexoViewModel);
        }

        // POST: Sexo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SexoViewModel sexo)
        {
            //if (ModelState.IsValid)
            //{
            var sexoDomain = AutoMapperConfig.Mapper.Map<SexoViewModel, Sexo>(sexo);
            sexoDomain.Usuario = "askdflas";
            sexoDomain.AtualizadoEm = DateTime.Now;
            _sexoService.Salvar(sexoDomain);

            return RedirectToAction("Index");
            //}

            //return View(sexo);
        }

        public ActionResult Delete (int id)
        {
            var sexoDomain = _sexoService.GetById(id);
            sexoDomain.Usuario = "Renato";
            sexoDomain.AtualizadoEm = DateTime.Now;
            sexoDomain.Status = false;
            _sexoService.Salvar(sexoDomain);

            return RedirectToAction("Index");
            //var db = new ProjetoEcommerceContext();
            //var ent = db.Sexo.Find(id);
            //ent.Status = false;
            //ent.AtualizadoEm = DateTime.Now;
            //ent.Usuario = "Renato";
            //db.Entry<Sexo>(ent).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            //return RedirectToAction("Index");
        }
    }
}
