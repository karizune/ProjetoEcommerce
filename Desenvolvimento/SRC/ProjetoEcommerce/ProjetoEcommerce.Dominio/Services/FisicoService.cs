using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

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

        public IEnumerable<Fisico> BuscarAtivos()
        {
            return _fisicoRepository.BuscarAtivos();
        }

        public bool Salvar (Fisico ent)
        {
            ent.AtualizadoEm = DateTime.Now;
            ent.Tipo = "F";
            ent.Foto = "avatar.png";
            if (ent.ClienteId == 0)
            {
                ent.CriadoEm = DateTime.Now;
                ent.Status = true;
                _fisicoRepository.Add(ent);
            }
            else
            {
                _fisicoRepository.Update(ent);
            }
            return true;

        }
    }
}
