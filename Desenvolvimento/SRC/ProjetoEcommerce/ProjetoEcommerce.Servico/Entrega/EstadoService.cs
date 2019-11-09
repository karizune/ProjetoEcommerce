using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class EstadoService : BaseService<Estado>, IEstadoService
    {
        private readonly EstadoRepository _repository;

        public EstadoService()
        {
            _repository = new EstadoRepository();
        }
    }
}