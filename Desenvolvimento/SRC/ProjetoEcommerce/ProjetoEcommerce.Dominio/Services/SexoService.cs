using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;

namespace ProjetoEcommerce.Dominio.Services
{
    public class SexoService : ServiceBase<Sexo>, ISexoService
    {
        private readonly ISexoRepository _sexoRepository;

        public SexoService(ISexoRepository sexoRepository)
            : base(sexoRepository)
        {
            _sexoRepository = sexoRepository;
        }
    }
}
