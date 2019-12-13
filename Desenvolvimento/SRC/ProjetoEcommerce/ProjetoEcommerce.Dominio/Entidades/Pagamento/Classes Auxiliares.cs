using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    /*eu estou usando a classe usuario para colocar as informações de cartão devido ai um problema que tenho com meu sql, irá ser substituido no codigo para ser usado do banco de dados.
     tambem notei um fluxo que deve ser seguido para se acessar os cartoes, onde o cartao deve ter um UsuarioID para que possamos encontrar o cartao do usuario. (usuario id vem da tabela usuario)*/
    public class Usuario : BaseEntity
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public int dinheiro { get; set; }
        public int cartaoID { get; set; }
        public string CardNumber { get; set; }
        public string Vencimento { get; set; }
        public int BandeiraCartaoID { get; set; }
        public List<Cartao> CartoesUsuario { get; set; } = new List<Cartao>()
        {
            new Cartao
            {
            }
        };
        public List<Carteira> CarteiraUsuario { get; set; } = new List<Carteira>()
        {
            new Carteira
            {
            }
        };
    }
    public class ProdutoCarrinho : BaseEntity
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string DescricaoProduto { get; set; }
        public string UrlImagem { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public float PrecoTotal
        {
            get
            {
                return Preco * Quantidade;
            }
        }
    } 
}
