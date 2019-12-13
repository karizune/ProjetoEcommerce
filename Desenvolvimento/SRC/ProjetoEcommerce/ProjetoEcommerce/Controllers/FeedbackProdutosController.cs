using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FeedbackProdutosController : Controller
    {
        private IFeedbackProdutoService _feedbackProdutoService;

        public FeedbackProdutosController(IFeedbackProdutoService feedbackProdutoService)
        {
            _feedbackProdutoService = feedbackProdutoService;
        }

        // GET: FeedbackProdutos
        public ActionResult Index()
        {
            var feeds = _feedbackProdutoService.GetAll();

            return View(feeds);
        }

        // GET: FeedbackProdutos/Details/5
        public ActionResult Details(int id)
        {
            var ent = _feedbackProdutoService.GetOneBy(f => f.IdFeedbackProduto == id);

            return View(ent);
        }

        // GET: FeedbackProdutos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeedbackProdutos/Create
        [HttpPost]
        public ActionResult Create(FeedbackProdutoViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<FeedbackProdutoViewModel, FeedbackProduto>(ent);
                _feedbackProdutoService.Add(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackProdutos/Edit/5
        public ActionResult Edit(int id)
        {
            var ent = _feedbackProdutoService.GetOneBy(f => f.IdFeedbackProduto == id);
            var mapped = MapperHelper.Container().Map<FeedbackProduto, FeedbackProdutoViewModel>(ent);

            return View(mapped);
        }

        // POST: FeedbackProdutos/Edit/5
        [HttpPost]
        public ActionResult Edit(FeedbackProdutoViewModel ent)
        {
            try
            {
                var mapped = MapperHelper.Container().Map<FeedbackProdutoViewModel, FeedbackProduto>(ent);
                _feedbackProdutoService.Update(mapped);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackProdutos/Delete/5
        public ActionResult Delete(int id)
        {
            var ent = _feedbackProdutoService.GetOneBy(f => f.IdFeedbackProduto == id);
            var mapped = MapperHelper.Container().Map<FeedbackProduto, FeedbackProdutoViewModel>(ent);

            return View(mapped);
        }

        // POST: FeedbackProdutos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var ent = _feedbackProdutoService.GetOneBy(f => f.IdFeedbackProduto == id);
                var mapped = MapperHelper.Container().Map<FeedbackProduto, FeedbackProdutoViewModel>(ent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
