using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEcommerce.Data.Repositories
{
    public class JuridicoRepository : RepositoryBase<Juridico>, IJuridicoRepository
    {
        public Cliente Autenticar(string email, string senha)
        {
            var emails = Db.email.Where(f => f.E_mail == email && f.Tipo == true).Select(x => x.ClienteId);

            return Db.juridico.SingleOrDefault(f => emails.Contains(f.ClienteId) && f.Senha == senha);
        }

        public IEnumerable<Juridico> BuscarAtivos()
        {
            return Db
                .juridico
                .Where(f => f.Status == true);
        }
    }
}
