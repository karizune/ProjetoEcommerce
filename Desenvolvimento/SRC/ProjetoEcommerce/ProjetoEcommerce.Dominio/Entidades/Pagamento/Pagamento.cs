namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Pagamento : BaseEntity
    {
        public int PagamentoID { get; set; }
        public decimal ValorTotal { get; set; }
        public int MetodoPagamentoID { get; set; }
        public int NroParcelamento { get; set; }
        public int? CartaoID { get; set; }
        public int StatusPagamentoID { get; set; }
        public int UsuarioID { get; set; }
        public int? BoletoID { get; set; }

        public Cartao Cartao { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public Boleto Boleto { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
        // public Usuario Usuario { get; set; }
        
    }
}
