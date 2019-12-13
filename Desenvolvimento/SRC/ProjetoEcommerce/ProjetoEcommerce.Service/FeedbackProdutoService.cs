using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Repositories.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using ProjetoEcommerce.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service
{
    public class FeedbackProdutoService : ServiceBase<FeedbackProduto>, IFeedbackProdutoService
    {
        private readonly IFeedbackProdutoReposytory _feedbackProdutoReposytory;
        public FeedbackProdutoService(IFeedbackProdutoReposytory feedbackProdutoRepository) : base(feedbackProdutoRepository)
        {
            _feedbackProdutoReposytory = feedbackProdutoRepository;
        }
    }
}
