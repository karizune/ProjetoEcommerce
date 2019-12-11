using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Service
{
    public class CartaoService : ICartaoService
    {
        private readonly ICartaoRepository _repository;
        public CartaoService(ICartaoRepository repository)
        {
            _repository = repository;
        }
        public void Add(Cartao obj)
        {
            obj.Status = 1;
            obj.Usuario = "Sistema";
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;

            _repository.Add(obj);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Cartao Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Cartao> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Cartao obj)
        {
            obj.AtualizadoEm = DateTime.Now;
            obj.Usuario = "Sistema";
            _repository.Update(obj);
        }
    }
}
