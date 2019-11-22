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
    public class ImagemService : IImagemService
    {
        private readonly IImagemRepository _repository;
        public ImagemService()
        {
            _repository = new ImagemRepository();
        }
        public IEnumerable<Imagem> BuscarAtivos()
        {
            return _repository.BuscarAtivos();
        }

        public bool Excluir(int imagemId, string usuario)
        {
            var ent= _repository.GetOne(imagemId);

            if (ent == null)
                return false;

            ent.Status = 0;
            ent.AtualizadoEm = DateTime.Now;
            ent.Usuario = usuario;
            _repository.Update(ent);

            return true;
        }

        public Imagem GetOneBy(int ImagemID)
        {
            return _repository.GetOneBy(ImagemID);
        }

        public bool Salvar(Imagem imagem)
        {
            imagem.AtualizadoEm = DateTime.Now;

            if (imagem.ImagemID == 0)
            {
                imagem.CriadoEm = DateTime.Now;
                _repository.Add(imagem);
            }
            else
            {
                _repository.Update(imagem);
            }
            return true;
        }
    }
}
