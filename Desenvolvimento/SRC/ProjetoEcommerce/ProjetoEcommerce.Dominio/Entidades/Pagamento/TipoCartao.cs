namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class TipoCartao : BaseEntity
    {
        public int TipoCartaoID { get; set; }
        public string Descricao { get; set; }
    }
}
