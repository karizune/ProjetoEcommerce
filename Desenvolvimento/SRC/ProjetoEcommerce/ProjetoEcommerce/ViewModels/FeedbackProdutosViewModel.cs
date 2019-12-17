using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class FeedbackProdutoViewModel
    {
        [DisplayName("ID")]
        public int IdFeedbackProduto { get; set; }
        [DisplayName("Usuario")]
        public int IdUsuario { get; set; }
        [DisplayName("Produto")]
        public int IdProduto { get; set; }
        [DisplayName("Estrelas")]
        public int Estrelas { get; set; }
        [DisplayName("Descricao")]
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Produto Produto { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

    }
}
