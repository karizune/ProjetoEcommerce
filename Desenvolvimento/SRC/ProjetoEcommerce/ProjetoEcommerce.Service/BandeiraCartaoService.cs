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
        private readonly IBandeiraCartaoRespository _bandeiraCartaoRespository;
        public BandeiraCartaoService(IBandeiraCartaoRespository bandeiraCartaoRespository)
        {
            _bandeiraCartaoRespository = bandeiraCartaoRespository;
        }

        public void Add(BandeiraCartao obj)
        {
            obj.Status = 1;
            obj.Usuario = "Sistema";
            obj.CriadoEm = DateTime.Now;
            obj.AtualizadoEm = DateTime.Now;

            _bandeiraCartaoRespository.Add(obj);
        }

        public void Delete(int id)
        {
            _bandeiraCartaoRespository.Delete(id);
        }

        public BandeiraCartao Get(int id)
        {
            return _bandeiraCartaoRespository.Get(id);
        }

        public IEnumerable<BandeiraCartao> GetAll()
        {
            return _bandeiraCartaoRespository.GetAll();
        }

        public void Update(BandeiraCartao obj)
        {
            obj.AtualizadoEm = DateTime.Now;
            obj.Usuario = "Sistema";

            _bandeiraCartaoRespository.Update(obj);
        }
    }
}
