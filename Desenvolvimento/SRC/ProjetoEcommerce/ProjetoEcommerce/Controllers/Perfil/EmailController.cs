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
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        // GET: Email
        public ActionResult Index()
        {
            var emailViewModel = AutoMapperConfig.Mapper.Map<IEnumerable<Email>, IEnumerable<EmailViewModel>>(_emailService.GetAll());
            return View(emailViewModel);
           
        }
        
        // GET: Email/Details/5
        public ActionResult Details(int id)
        {
            var email = _emailService.GetById(id);
            var emailViewModel = AutoMapperConfig.Mapper.Map<Email, EmailViewModel>(email);
            return View(emailViewModel);
        }

        // GET: Email/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Email/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmailViewModel email)
        {
            if (ModelState.IsValid)
            {
                var emailDomain = AutoMapperConfig.Mapper.Map<EmailViewModel, Email>(email);
                emailDomain.Usuario = "System";
                _emailService.Add(emailDomain);

                return RedirectToAction("Index");
            }

            return View(email);
        }

        // GET: Email/Edit/5
        public ActionResult Edit(int id)
        {
            var email = _emailService.GetById(id);
            var emailViewModel = AutoMapperConfig.Mapper.Map<Email, EmailViewModel>(email);
            return View(emailViewModel);
        }

        // POST: Email/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmailViewModel email)
        {
            if (ModelState.IsValid)
            {
                var emailDomain = AutoMapperConfig.Mapper.Map<EmailViewModel, Email>(email);
                emailDomain.Usuario = "System";
                emailDomain.AtualizadoEm = DateTime.Now;
                _emailService.Salvar(emailDomain);

                return RedirectToAction("Index");
            }
            return View(email);
        }

        // GET: Email/Delete/5
        public ActionResult Delete(int id)
        {
            var emailDomain = _emailService.GetById(id);
            emailDomain.Usuario = "Renato";
            emailDomain.AtualizadoEm = DateTime.Now;
            emailDomain.Status = false;
            _emailService.Salvar(emailDomain);

            return RedirectToAction("Index");
        }
    }
}
