using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using ProjetoEcommerce.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Service
{
    public class BandeiraCartaoService : IBandeiraCartaoService
    {
        private readonly IBandeiraCartaoRespository _repository;
        public BandeiraCartaoService(IBandeiraCartaoRespository repository)
        {
            _repository = repository;
        }

        public void Add(BandeiraCartao obj)
        {
            obj.Status = 1;
            obj.Usuario = "Sistema";
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;

            _repository.Add(obj);
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            ent.Status = ent.Status == 1 ? 0 : 1;
            Update(ent);
        }

        public BandeiraCartao Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<BandeiraCartao> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(BandeiraCartao obj)
        {
            obj.AtualizadoEm = DateTime.Now;
            obj.Usuario = "Sistema";

            _repository.Update(obj);
        }
    }
}
