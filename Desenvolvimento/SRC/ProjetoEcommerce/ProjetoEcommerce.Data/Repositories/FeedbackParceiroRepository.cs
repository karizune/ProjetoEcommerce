using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Marketplace;

namespace ProjetoEcommerce.Data.Repositories
{
    public class FeedbackParceiroRepository : RepositoryBase<FeedbackParceiro>, IFeedbackParceiroRepository
    {
        public IEnumerable<FeedbackParceiro> GetAtivosPorNomeUsuario(string nome)
        {
            //return Db.Set<FeedbackParceiro>()
            //    .Include("Usuario")
            //    .Include("Parceiro")
            //    .Where(f => f.Usuario.Nome.Contains(nome));
            return null;
        }

        public IEnumerable<FeedbackParceiro> GetFeedbacksAtivosPorUsuario(int IdUsuario)
        {
            //return Db.Set<FeedbackParceiro>()
            //    .Include("Usuario")
            //    .Include("Parceiro")
            //    .Where(f => f.IdUsuario == IdUsuario);   
            return null;
        }
        
    }
}
