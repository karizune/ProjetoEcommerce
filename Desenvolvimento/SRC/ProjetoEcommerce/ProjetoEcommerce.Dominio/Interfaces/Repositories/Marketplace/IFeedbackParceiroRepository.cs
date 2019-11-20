using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Marketplace
{
    public interface IFeedbackParceiroRepository : IRepositoryBase<FeedbackParceiro>
    {
        IEnumerable<FeedbackParceiro> GetFeedbacksAtivosPorUsuario(int IdUsuario);
        IEnumerable<FeedbackParceiro> GetAtivosPorNomeUsuario(string nome);
    }
}
