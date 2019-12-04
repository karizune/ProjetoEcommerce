using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagamentoCarteiraViewModel
    {
        public Carteira Carteira{ get; set; }
        public IEnumerable<ProdutoCarrinho> ListaProdutos { get; set; }
        public PagamentoCarteiraViewModel(IEnumerable<ProdutoCarrinho> listaProdutos)
        {
            Carteira = new Carteira();
            ListaProdutos = listaProdutos;
        }
    }
}