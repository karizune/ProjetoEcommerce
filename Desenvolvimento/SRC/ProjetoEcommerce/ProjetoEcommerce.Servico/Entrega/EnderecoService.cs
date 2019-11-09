using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly EnderecoRepository _repository;

        public EnderecoService()
        {
            _repository = new EnderecoRepository();
        }
    }
}