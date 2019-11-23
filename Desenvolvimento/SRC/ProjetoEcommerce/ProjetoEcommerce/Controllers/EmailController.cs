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
            var emailViewModel = Mapper.Map<IEnumerable<Email>, IEnumerable<EmailViewModel>>(_emailService.GetAll());
            return View(emailViewModel);
           
        }
        
        // GET: Email/Details/5
        public ActionResult Details(int id)
        {
            var email = _emailService.GetById(id);
            var emailViewModel = Mapper.Map<Email, EmailViewModel>(email);
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
                var emailDomain = Mapper.Map<EmailViewModel, Email>(email);
                _emailService.Add(emailDomain);

                return RedirectToAction("Index");
            }

            return View(email);
        }

        // GET: Email/Edit/5
        public ActionResult Edit(int id)
        {
            var email = _emailService.GetById(id);
            var emailViewModel = Mapper.Map<Email, EmailViewModel>(email);
            return View(emailViewModel);
        }

        // POST: Email/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmailViewModel email)
        {
            if (ModelState.IsValid)
            {
                var emailDomain = Mapper.Map<EmailViewModel, Email>(email);
                _emailService.Update(emailDomain);

                return RedirectToAction("Index");
            }
            return View(email);
        }

        // GET: Email/Delete/5
        public ActionResult Delete(int id)
        {
            var email = _emailService.GetById(id);
            var emailViewModel = Mapper.Map<Email, EmailViewModel>(email);
            return View(emailViewModel);
        }

        // POST: Email/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var email = _emailService.GetById(id);
            _emailService.Remove(email);

            return RedirectToAction("Index");
        }
    }
}
