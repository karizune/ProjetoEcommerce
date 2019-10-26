namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Cartao_Tipo : BaseEntity
    {
        public int CartaoID { get; set; }
        public int TipoCartaoID { get; set; }
        public Cartao cartao { get; set; }
        public TipoCartao tipoCartao { get; set; }
    }
}
