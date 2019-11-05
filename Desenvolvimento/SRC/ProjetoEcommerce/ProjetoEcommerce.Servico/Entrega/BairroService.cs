using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class BairroService : IBairroService
    {
        private readonly BairroRepository _repository;
        public BairroService()
        {
            _repository = new BairroRepository();
        }
        public Bairro Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Bairro> GetAll()
        {
            return _repository.GetAll();
        }

        public Bairro GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Bairro Save(Bairro obj)
        {
            return _repository.Save(obj);
        }

        public Bairro Update(Bairro obj)
        {
            return Update(obj);
        }
    }
}
