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
    public class CidadeService : ICidadeService
    {
        private readonly CidadeRepository _repository;
        public CidadeService()
        {
            _repository = new CidadeRepository();
        }
        public Cidade Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Cidade> GetAll()
        {
            return _repository.GetAll();
        }

        public Cidade GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Cidade Save(Cidade obj)
        {
            return _repository.Save(obj);
        }

        public Cidade Update(Cidade obj)
        {
            return _repository.Update(obj);
        }
    }
}
