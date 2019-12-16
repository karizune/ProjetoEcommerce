using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface ICartao_TipoRepository : IRepositoryBase<Cartao_Tipo>
    {
        Cartao_Tipo Get(int CartaoID, int TipoCartaoID);
        void Delete(int CartaoID, int TipoCartaoID);
    }
}
