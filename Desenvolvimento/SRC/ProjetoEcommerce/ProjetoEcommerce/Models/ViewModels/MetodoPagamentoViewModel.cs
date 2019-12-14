using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Entidades.Pagamento.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class MetodoPagamentoViewModel
    {
        public IList<ProdutoCarrinho> ListaProdutos { get; set; }
        public IEnumerable<MetodoPagamento> MetodosPagamento { get; set; }
        public Cartao Cartao { get; set; }
        public Usuario usuario { get; set; }
        
        public float PrecoTotalVenda
        {
            get
            {
                float soma = 0;
                foreach (var item in ListaProdutos)
                {
                    soma += item.PrecoTotal;
                }
                return soma;
            }
        }

        public MetodoPagamentoViewModel()
        {
            Cartao = new Cartao();
        }

        public MetodoPagamentoViewModel(IList<ProdutoCarrinho> listaProdutos, IEnumerable<MetodoPagamento> listaMetodos, Usuario Usuario) : this()
        {
            ListaProdutos = listaProdutos;
            MetodosPagamento = listaMetodos;
            usuario = Usuario;
        }

    }
}