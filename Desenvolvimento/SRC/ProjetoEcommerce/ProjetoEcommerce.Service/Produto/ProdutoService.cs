using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service
{
    public class ProdutoService : IProdutoService
    {
        public IEnumerable<Dominio.Entidades.Produto> BuscarAtivos()
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int produtoId, string usuario)
        {
            throw new NotImplementedException();
        }

        public Dominio.Entidades.Produto GetOneBy(int ProdutoID)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(Dominio.Entidades.Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
