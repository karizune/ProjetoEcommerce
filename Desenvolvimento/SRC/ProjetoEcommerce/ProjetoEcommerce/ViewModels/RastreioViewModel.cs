using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class RastreioViewModel
    {
        [DisplayName("Rastreio")]
        public int IdRastreio { get; set; }
        [DisplayName("Codigo de rastreamento")]
        public string CodigoRastreio { get; set; }
        [DisplayName("Codigo de pacote")]
        public string CodigoPacote { get; set; }
        [DisplayName("Destinatario Rastreio")]
        public string DestinatarioRastreio { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
