using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class CidadeService : BaseService<Cidade>, ICidadeService
    {
        private readonly CidadeRepository _repository;

        public CidadeService()
        {
            _repository = new CidadeRepository();
        }
    }
}