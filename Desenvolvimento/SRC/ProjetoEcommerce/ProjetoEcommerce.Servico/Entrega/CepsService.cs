using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class CepsService : BaseService<Ceps>, ICepsService
    {
        private readonly CepsRepository _repository;

        public CepsService()
        {
            _repository = new CepsRepository();
        }
    }
}