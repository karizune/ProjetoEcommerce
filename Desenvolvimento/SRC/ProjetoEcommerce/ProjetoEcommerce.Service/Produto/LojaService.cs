using ProjetoEcommerce.Data.Repositories;
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
    public class LojaService : ILojaService
    {
        private readonly ILojaRepository _repository;

        public LojaService()
        {
            _repository = new LojaRepository();
        }
        public Loja GetOneBy(int LojaID)
        {
            return _repository.GetOneBy(LojaID);
        }

        public IEnumerable<Loja> BuscarAtivos()
        {
            return _repository.BuscarAtivos();
        }

        public bool Excluir(int lojaId, string usuario)
        {
            var ent = _repository.GetOne(lojaId);

            if (ent == null)
                return false;

            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = usuario;
            _repository.Update(ent);

            return true;
        }

        public bool Salvar(Loja loja)
        {
            loja.AtualizadoEm = DateTime.Now;

            if (loja.LojaID == 0)
            {
                loja.CriadoEm = DateTime.Now;
                _repository.Add(loja);
            }
            else
            {
                _repository.Update(loja);
            }

            return true;
        }
    }
}
