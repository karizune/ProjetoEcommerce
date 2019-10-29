using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Marketplace;
using ProjetoEcommerce.Service.Interfaces;
using ProjetoEcommerce.Service.Interfaces.Marketplace;

namespace ProjetoEcommerce.Service
{
    public class FeedbackParceiroService : ServiceBase<FeedbackParceiro>, IFeedbackParceiroService
    {
        private readonly IFeedbackParceiroRepository _feedbackParceiroRepository;

        public FeedbackParceiroService(IFeedbackParceiroRepository feedbackParceiroRepository) : base(feedbackParceiroRepository)
        {
            _feedbackParceiroRepository = feedbackParceiroRepository;
        }

    }
}
