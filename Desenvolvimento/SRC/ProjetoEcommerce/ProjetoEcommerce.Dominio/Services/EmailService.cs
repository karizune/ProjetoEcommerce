using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Services
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        private readonly IEmailRepository _emailRepository;

        public EmailService(IEmailRepository emailRepository)
            : base(emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public IEnumerable<Email> BuscarAtivos()
        {
            return _emailRepository.BuscarAtivos();
        }

        public bool Salvar(Email ent)
        {
            ent.AtualizadoEm = DateTime.Now;
            if (ent.IDEmail == 0)
            {
                ent.CriadoEm = DateTime.Now;
                ent.Status = true;
                _emailRepository.Add(ent);
            }
            else
            {
                _emailRepository.Update(ent);
            }

            return true;
        }
    }
}
