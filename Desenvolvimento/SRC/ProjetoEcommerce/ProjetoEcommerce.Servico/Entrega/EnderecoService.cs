using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Interfaces.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class EnderecoService : IEnderecoService
    {
        private readonly EnderecoRepository _repository;
        public EnderecoService()
        {
            _repository = new EnderecoRepository();
        }
        public Endereco Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _repository.GetAll();
        }

        public Endereco GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Endereco Save(Endereco obj)
        {
            return Save(obj);
        }

        public Endereco Update(Endereco obj)
        {
            return Update(obj);
        }
    }
}
