using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class Rastreio
    {
        public Rastreio()
        {
            this.Vendas = new HashSet<Venda>();
        }
        public int IdRastreio { get; set; }
        public string CodigoRastreio { get; set; }
        public string CodigoPacote { get; set; }
        public string DestinatarioRastreio { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
