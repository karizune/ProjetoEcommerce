using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Marketplace;
using ProjetoEcommerce.Service.Interfaces;
using ProjetoEcommerce.Service.Interfaces.Marketplace;

namespace ProjetoEcommerce.Service
{
    public class ParceiroService : ServiceBase<Parceiro>, IParceiroService
    {
        private readonly IParceiroRepository _parceiroRepository;

        public ParceiroService(IParceiroRepository parceiroRepository) : base(parceiroRepository)
        {
            _parceiroRepository = parceiroRepository;
        }


    }
}
