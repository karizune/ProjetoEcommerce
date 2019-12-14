using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using ProjetoEcommerce.Dominio.Interfaces.Base;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IRelatorioRepository : IRepositoryBase<Relatorio>
    {
        Relatorio GetOneBy(int relatorioId);
    }
}
