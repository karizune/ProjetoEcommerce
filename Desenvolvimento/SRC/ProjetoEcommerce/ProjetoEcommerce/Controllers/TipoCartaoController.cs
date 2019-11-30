using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class TipoCartaoController : Controller
    {
        public ActionResult Index()
        {
            var tiposDeCartoes =
                new ProjetoEcommerceContext()
                    .TipoCartao
                    .Where(f => f.Status == 1)
                    .ToList();

            return View(tiposDeCartoes);
        }


        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult IncluirConfirm(TipoCartao ent)
        {
            var db = new ProjetoEcommerceContext();
            ent.Status = 1;
            ent.Usuario = "renato";
            ent.CriadoEm = DateTime.Now;
            ent.AtualizadoEm = DateTime.Now;
            db.TipoCartao.Add(ent);
            db.SaveChanges();

            return Redirect("Index");
        }

        public ActionResult Excluir(int tipoCartaoId)
        {
            var db = new ProjetoEcommerceContext();
            var ent = db.TipoCartao.Find(tipoCartaoId);
            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = "renato";
            db.Entry<TipoCartao>(ent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Redirect("Index");
        }

  
    }
}