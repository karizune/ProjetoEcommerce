using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
namespace ProjetoEcommerce.Dominio.Entidades.Pagamento.ViewModels
{
    public class PagarViewModel : BaseViewModel
    {
        public IEnumerable<TipoCartao> TiposCartoes;
        public IEnumerable<MetodoPagamento> metodosPagamento;
        public IEnumerable<BandeiraCartao> bandeirasCartao;
        public IEnumerable<ProdutoCarrinho> produtosCarrinho;
        public Boleto Boleto;
        public Cartao cartao;
        public int cvc;
        public PagarViewModel(IEnumerable<ProdutoCarrinho> ProdutosCarrinho)
        {
            ProjetoEcommerceContext C = new ProjetoEcommerceContext();
            TiposCartoes = C.TipoCartao.ToList();
            metodosPagamento = C.MetodoPagamento.ToList();
            bandeirasCartao = C.BandeiraCartao.ToList();
            produtosCarrinho = ProdutosCarrinho;
        }
    }
    public class ProdutoCarrinho
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
