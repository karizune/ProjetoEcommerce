using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System.Collections.Generic;

namespace ProjetoEcommerce.Service.Interfaces.Marketplace
{
    public interface IFeedbackParceiroService : IServiceBase<FeedbackParceiro>
    {
        IEnumerable<FeedbackParceiro> GetFeedbacksAtivosPorUsuario(int IdUsuario);
        IEnumerable<FeedbackParceiro> GetAtivosPorNomeUsuario(string nome);
    }
}
