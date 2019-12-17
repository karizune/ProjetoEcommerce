using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.Models.ViewModels
{
    public class PagarCartaoViewModel
    {
       
        public IList<ProdutoCarrinho> ListaProdutos { get; set; }
        public Usuario Usuario { get; set; }
        public Cartao Cartao { get; set; }
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
        public PagarCartaoViewModel()
        {

        }
        public PagarCartaoViewModel(IList<ProdutoCarrinho> listaProdutos, Usuario usuario)
        {
            ListaProdutos = listaProdutos;
            Usuario = usuario;
            
        }

    }
}