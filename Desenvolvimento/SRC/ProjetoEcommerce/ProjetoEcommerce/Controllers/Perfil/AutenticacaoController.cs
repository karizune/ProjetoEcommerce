using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using ProjetoEcommerce.ViewModels.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class AutenticacaoController : Controller
    {
        private readonly IFisicoService _fisicoService;
        private readonly IJuridicoService _juridicoService;

        public AutenticacaoController(IFisicoService fisicoService, IJuridicoService juridicoService)
        {
            _fisicoService = fisicoService;
            _juridicoService = juridicoService;
        }

        // GET: Autenticacao
        public ActionResult Entrar()
        {
            return View();
        }

        public ActionResult Sair()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EntrarConfirm(AutenticacaoViewModel ent)
        {

            Cliente cliente;
            if (ent.Tipo == Dominio.Entidades.ClienteTipo.Fisico)
            {
                cliente = _fisicoService.Autenticar(ent.Email, ent.Senha);
            }
            else
            {
                cliente = _juridicoService.Autenticar(ent.Email, ent.Senha);
            }

            Session["UsuarioNome"] = cliente.Nome;
            Session["UsuarioId"] = cliente.ClienteId;

            return RedirectToAction("Index", "Home");
        }
    }
}