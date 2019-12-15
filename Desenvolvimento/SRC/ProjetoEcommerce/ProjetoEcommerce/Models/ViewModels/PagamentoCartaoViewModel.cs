using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagamentoCartaoViewModel
    {
        //{
        //    public Cartao Cartao { get; set; }
        //    public IEnumerable<ProdutoCarrinho> ListaProdutos { get; set; }
        //    public PagamentoCartaoViewModel(IEnumerable<ProdutoCarrinho> listaProdutos)
        //    {
        //        Cartao = new Cartao();
        //        ListaProdutos = listaProdutos;
        //    }
        //}
        public IList<ProdutoCarrinho> ListaProdutos { get; set; }
        public IEnumerable<MetodoPagamento> MetodosPagamento { get; set; }
        public Cartao Cartao { get; set; }
        public Usuario usuario { get; set; }

        public decimal PrecoTotalVenda
        {
            get
            {
                decimal soma = 0M;
                foreach (var item in ListaProdutos)
                {
                    soma += item.PrecoTotal;
                }
                return soma;
            }
        }
        public PagamentoCartaoViewModel(IList<ProdutoCarrinho> listaProdutos, IEnumerable<MetodoPagamento> listaMetodos, Usuario Usuario)
        {
            ListaProdutos = listaProdutos;
            MetodosPagamento = listaMetodos;
            Cartao = new Cartao();
            usuario = Usuario;
        }

    }
}