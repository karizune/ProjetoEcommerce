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
        public IEnumerable<ProdutoCarrinho> ListaProdutos { get; set; }
        public IEnumerable<MetodoPagamento> MetodosPagamento { get; set; }
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
        public MetodoPagamentoViewModel(IEnumerable<ProdutoCarrinho> listaProdutos, IEnumerable<MetodoPagamento> listaMetodos)
        {
            ListaProdutos = listaProdutos;
            MetodosPagamento = listaMetodos;
        }

    }
}