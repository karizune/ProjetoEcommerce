using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Services.Produto
{
    public interface IMarcaService
    {
        bool Excluir(int marcaId, string usuario);
        bool Salvar(Marca marca);
        Marca GetOneBy(int MarcaID);
        IEnumerable<Marca> BuscarAtivos();
    }
}
