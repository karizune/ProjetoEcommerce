using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;

namespace ProjetoEcommerce.Dominio.Services
{
    public class FisicoService : ServiceBase<Fisico>, IFisicoService
    {
        private readonly IFisicoRepository _fisicoRepository;

        public FisicoService(IFisicoRepository fisicoRepository)
            : base(fisicoRepository)
        {
            _fisicoRepository = fisicoRepository;
        }
    }
}
