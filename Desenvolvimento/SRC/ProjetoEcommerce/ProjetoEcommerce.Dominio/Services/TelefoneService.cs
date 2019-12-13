using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Services
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository)
            :base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public IEnumerable<Telefone> BuscarAtivos()
        {
            return _telefoneRepository.BuscarAtivos();
        }

        public bool Salvar(Telefone ent)
        {
            ent.AtualizadoEm = DateTime.Now;
            if (ent.IDTelefone == 0)
            {
                ent.CriadoEm = DateTime.Now;
                ent.Status = true;
                _telefoneRepository.Add(ent);
            }
            else
            {
                _telefoneRepository.Update(ent);
            }

            return true;
        }
    }
}
