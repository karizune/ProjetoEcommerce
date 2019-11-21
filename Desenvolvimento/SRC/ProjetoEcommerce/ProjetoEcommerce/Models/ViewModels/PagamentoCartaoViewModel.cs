using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagamentoCartaoViewModel
    {
        public Cartao Cartao { get; set; }
        public IEnumerable<ProdutoCarrinho> ListaProdutos { get; set; }
        public PagamentoCartaoViewModel(IEnumerable<ProdutoCarrinho> listaProdutos)
        {
            Cartao = new Cartao();
            ListaProdutos = listaProdutos;
        }
    }
}