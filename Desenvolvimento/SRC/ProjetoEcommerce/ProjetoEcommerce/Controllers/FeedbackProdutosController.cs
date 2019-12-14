using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers
{
    public class FeedbackProdutosController : Controller
    {
        private IFeedbackProdutoService _feedbackProdutoService;
        private List<Produto> _Produtos;

        public FeedbackProdutosController(IFeedbackProdutoService feedbackProdutoService)
        {
            _feedbackProdutoService = feedbackProdutoService;
            _Produtos = new List<Produto>();

            _Produtos.Add(new Produto
            {
                IdProduto = 1,
                Nome = "BICICRETA"
            });

            _Produtos.Add(new Produto
            {
                IdProduto = 3,
                Nome = "OTA BICICRETA"
            });

        }

        // GET: FeedbackProdutos
        public ActionResult Index()
        {
            var feeds = _feedbackProdutoService.GetAll();
            var mapped = MapperHelper.Container().Map<IEnumerable<FeedbackProduto>, IEnumerable<FeedbackProdutoViewModel>>(feeds);
            return View(mapped);
        }

        // GET: FeedbackProdutos/Details/5
        public ActionResult Details(int id)
        {
            var ent = _feedbackProdutoService.GetOneBy(f => f.IdFeedbackProduto == id);
            var mapped = MapperHelper.Container().Map<FeedbackProduto, FeedbackProdutoViewModel>(ent);
            return View(mapped);
        }

        // GET: FeedbackProdutos/Create
        public ActionResult Create()
        {
            var ent = new FeedbackProdutoViewModel();
            ent.IdUsuario = 1;
            ent.Produtos = _Produtos;

            return View(ent);
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
            mapped.Produtos = _Produtos;

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
                _feedbackProdutoService.Delete(ent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
