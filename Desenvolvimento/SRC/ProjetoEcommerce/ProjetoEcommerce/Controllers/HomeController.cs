using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeedbackParceiroService _feedbackParceiroService;
        //private readonly IFeedbackProdutoService _feedbackProdutoService;
        //private readonly IRastreioService _rastreioService;
        //private readonly IParceiroService _parceiroService;

        public HomeController(IFeedbackParceiroService feedbackParceiroService)
        {
            _feedbackParceiroService = feedbackParceiroService;
        }
        //public HomeController(IFeedbackProdutoService  feedbackProdutoService)
        //{
        //    _feedbackProdutoService = feedbackProdutoService;
        //}
        //public HomeController(IRastreioService rastreioService)
        //{
        //    _rastreioService = rastreioService;
        //}
        //public HomeController(IParceiroService parceiroService)
        //{
        //    _parceiroService = parceiroService;
        //}

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListFeedbackParceiros()
        {
            var fb = _feedbackParceiroService.GetAll().ToList();
            return View(fb);
        }
        //public ActionResult ListFeedbackProdutos()
        //{
        //    var fb = _feedbackProdutoService.GetAll().ToList();
        //    return View(fb);
        //}
        //public ActionResult ListRastreio()
        //{
        //    var fb = _rastreioService.GetAll().ToList();
        //    return View(fb);
        //}
        //public ActionResult ListaParceiro()
        //{
        //    var fb = _parceiroService.GetAll().ToList();
        //    return View(fb);
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}