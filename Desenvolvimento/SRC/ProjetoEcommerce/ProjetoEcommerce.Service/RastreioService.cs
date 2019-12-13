using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Marketplace;
using ProjetoEcommerce.Service.Interfaces;
using ProjetoEcommerce.Service.Interfaces.Marketplace;

namespace ProjetoEcommerce.Service
{
    public class RastreioService : ServiceBase<Rastreio>, IRastreioService
    {
        private readonly IRastreioRepository _rastreioRepository;

        public RastreioService(IRastreioRepository rastreioRepository) : base(rastreioRepository)
        {
            _rastreioRepository = rastreioRepository;
        }


    }
}
