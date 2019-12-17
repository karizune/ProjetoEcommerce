namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class MetodoPagamento : BaseEntity
    {
        public int MetodoPagamentoID { get; set; }
        public string Descricao { get; set; }
        public string FA { get; set; }
        public string Action { get; set; }

    }
}
