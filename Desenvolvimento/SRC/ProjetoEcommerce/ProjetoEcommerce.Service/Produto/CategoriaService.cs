using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades.Produto;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service.Produto
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService()
        {
            _repository = new CategoriaRepository();
        }

        public Categoria GetOneBy(int CategoriaID)
        {
            return _repository.GetOneBy(CategoriaID);
        }

        public IEnumerable<Categoria> BuscarAtivos()
        {
            return _repository.BuscarAtivos();
        }

        public bool Excluir(int categoriaId, string usuario)
        {
            var ent = _repository.GetOne(categoriaId);

            if (ent == null)
                return false;

            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = usuario;
            _repository.Update(ent);

            return true;
        }

        public bool Salvar(Categoria categoria)
        {
            categoria.AtualizadoEm = DateTime.Now;

            if (categoria.CategoriaID == 0)
            {
                categoria.CriadoEm = DateTime.Now;
                _repository.Add(categoria);
            }
            else
            {
                _repository.Update(categoria);
            }

            return true;
        }

    }
}
