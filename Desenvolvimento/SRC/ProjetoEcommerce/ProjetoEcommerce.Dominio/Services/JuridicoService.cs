using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

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

        public IEnumerable<Juridico> BuscarAtivos()
        {
            return _juridicoRepository.BuscarAtivos();
        }

        public bool Salvar(Juridico ent)
        {
            ent.AtualizadoEm = DateTime.Now;
            ent.Tipo = "J";
            ent.Foto = "avatar.png";
            if (ent.ClienteId == 0)
            {
                ent.CriadoEm = DateTime.Now;
                ent.Status = true;
                _juridicoRepository.Add(ent);
            }
            else
            {
                _juridicoRepository.Update(ent);
            }
            return true;

        }
    }
}
