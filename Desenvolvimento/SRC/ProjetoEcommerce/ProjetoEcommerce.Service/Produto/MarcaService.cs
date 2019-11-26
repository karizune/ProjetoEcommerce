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
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _repository;
        public MarcaService()
        {
            _repository = new MarcaRepository();
        }
        public Marca GetOneBy(int MarcaID)
        {
            return _repository.GetOneBy(MarcaID);
        }
        public IEnumerable<Marca> BuscarAtivos()
        {
            return _repository.BuscarAtivos();
        }

        public bool Excluir(int marcaId, string usuario)
        {
            var ent = _repository.GetOne(marcaId);

            if (ent == null)
                return false;

            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = usuario;
            _repository.Update(ent);

            return true;
        }

        public bool Salvar(Marca marca)
        {
            marca.AtualizadoEm = DateTime.Now;

            if (marca.MarcaID == 0)
            {
                marca.CriadoEm = DateTime.Now;
                _repository.Add(marca);
            }
            else
            {
                _repository.Update(marca);
            }

            return true;
        }
    }
}
