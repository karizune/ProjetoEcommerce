using ProjetoEcommerce.Dominio.Entidades;
using System.Collections.Generic;


namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface IImagemService
    {
        bool Excluir(int imagemId, string usuario);
        bool Salvar(Imagem imagem);
        Imagem GetOneBy(int ImagemID);
        IEnumerable<Imagem> BuscarAtivos();
    }
}
