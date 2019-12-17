using ProjetoEcommerce.Dominio.Entidades.Pagamento;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagarMetodoViewModel
    {
        public IList<ProdutoCarrinho> ListaProdutos { get; set; }
        public IEnumerable<MetodoPagamento> MetodosPagamento { get; set; }
        public Usuario Usuario { get; set; }
        
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

        public PagarMetodoViewModel(IList<ProdutoCarrinho> listaProdutos, IEnumerable<MetodoPagamento> listaMetodos, Usuario usuario)
        {
            ListaProdutos = listaProdutos;
            MetodosPagamento = listaMetodos;
            Usuario = usuario;
        }

    }
}