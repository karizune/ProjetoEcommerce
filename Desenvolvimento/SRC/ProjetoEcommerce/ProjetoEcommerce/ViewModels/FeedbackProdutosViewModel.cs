using System;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class FeedbackProdutoViewModel
    {
        public int IdFeedbackProduto { get; set; }
        public int IdUsuario { get; set; }
        public int IdProduto { get; set; }
        public int Estrelas { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
