using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.EntityFramework.Repository.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Entrega.Interfaces;
using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Servico.Entrega
{
    public class RuaService : IRuaService
    {
        private readonly RuaRepository _repository;
        public RuaService()
        {
            _repository = new RuaRepository();
        }
        public Rua Delete(int id, string usuario)
        {
            return _repository.Delete(id, usuario);
        }

        public IEnumerable<Rua> GetAll()
        {
           return _repository.GetAll();
        }

        public Rua GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Rua Save(Rua obj)
        {
            return _repository.Save(obj);
        }

        public Rua Update(Rua obj)
        {
            return _repository.Update(obj);
        }
    }
}
