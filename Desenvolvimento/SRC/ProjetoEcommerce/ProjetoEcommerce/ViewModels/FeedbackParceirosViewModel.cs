using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class FeedbackParceiroViewModel
    {
        [DisplayName("ID")]
        public int IdFeedbackParceiro { get; set; }
        [DisplayName("Usuario")]
        public int IdUsuario { get; set; }
        [DisplayName("Parceiro")]
        public int IdParceiro { get; set; }
        [DisplayName("Estrelas")]
        public int Estrelas { get; set; }
        [DisplayName("Descricao")]
        public string Descricao { get; set; }
        [DisplayName("Data de Cdastro")]
        public DateTime DataCadastro { get; set; }


        public virtual Usuario Usuario { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public IEnumerable<Usuario> Usuarios { get; set; }
        public IEnumerable<Parceiro> Parceiros { get; set; }
    }
}
