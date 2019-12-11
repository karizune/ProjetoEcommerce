using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
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
        private readonly IProdutoRepository _repository;
        public ProdutoService()
        {
            _repository = new ProdutoRepository();
        }
        public IEnumerable<Produto> BuscarAtivos()
        {
            return _repository.BuscarAtivos();
        }

        public bool Excluir(int produtoId, string usuario)
        {
            var ent = _repository.GetOne(produtoId);

            if (ent == null)
                return false;

            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = usuario;
            _repository.Update(ent);

            return true;
        }

        public Produto GetOneBy(int ProdutoID)
        {
            return _repository.GetOneBy(ProdutoID);
        }

        public bool Salvar(Dominio.Entidades.Produto produto)
        {
            produto.AtualizadoEm = DateTime.Now;

            if (produto.ProdutoID == 0)
            {
                produto.CriadoEm = DateTime.Now;
                _repository.Add(produto);
            }
            else
            {
                _repository.Update(produto);
            }

            return true;
        }
    }
}
