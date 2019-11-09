using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Interfaces;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class BairroService : BaseService<Bairro>, IBairroService
    {
        private readonly BairroRepository _repository;

        public BairroService()
        {
            _repository = new BairroRepository();
        }
    }
}