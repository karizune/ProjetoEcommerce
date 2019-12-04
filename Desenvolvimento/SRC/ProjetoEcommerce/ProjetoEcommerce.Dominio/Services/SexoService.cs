using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;

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

        public bool Salvar(Sexo ent)
        {
            ent.AtualizadoEm = DateTime.Now;
            if (ent.IDSexo == 0)
            {
                ent.CriadoEm = DateTime.Now;
                ent.Status = true;
                _sexoRepository.Add(ent);
            }
            else
            {
                _sexoRepository.Update(ent);
            }

            return true;
        }
    }
}
