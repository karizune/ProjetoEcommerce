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
        public int ID = 1;
        public string Nome = "Jose oswaldo da silva cunha vieira resende borges honorato junior oliveira dos santos";
        public string Endereco = "Rua São Domingos dorminhocos";
        public string CEP ="00000-000";
        public int dinheiro = 100;
        public int? cartaoID = 1;
        public string CardNumber = "1111222233334444";
        public string Vencimento = "01/01";
        public int BandeiraCartaoID = 1;
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
