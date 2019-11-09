using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Interfaces;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class RuaService : BaseService<Rua>, IRuaService
    {
        private readonly RuaRepository _repository;

        public RuaService()
        {
            _repository = new RuaRepository();
        }
    }
}