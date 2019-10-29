using System;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class FeedbackParceiroViewModel
    {
        public int IdFeedbackParceiro { get; set; }
        public int IdUsuario { get; set; }
        public int IdParceiro { get; set; }
        public int Estrelas { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Parceiro Parceiro { get; set; }

    }
}
