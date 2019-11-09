using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Perfil;

namespace ProjetoEcommerce.Data.Repositories
{
    class EmailRepository : IEmailRepository
    {
        private readonly ProjetoEcommerceContext _context;

        public EmailRepository(ProjetoEcommerceContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Email> Emails => _context.email;
    }
}
