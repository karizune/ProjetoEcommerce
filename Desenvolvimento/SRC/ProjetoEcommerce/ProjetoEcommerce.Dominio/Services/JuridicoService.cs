using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;

namespace ProjetoEcommerce.Dominio.Services
{
    public class JuridicoService : ServiceBase<Juridico>, IJuridicoService
    {
        private readonly IJuridicoRepository _juridicoRepository;

        public JuridicoService(IJuridicoRepository juridicoRepository)
            : base(juridicoRepository)
        {
            _juridicoRepository = juridicoRepository;
        }
    }
}
