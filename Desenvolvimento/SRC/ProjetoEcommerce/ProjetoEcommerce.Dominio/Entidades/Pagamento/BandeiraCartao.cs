namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class BandeiraCartao : BaseEntity
    {
        public int BandeiraCartaoID { get; set; }
        public string Descricao { get; set; }
        public string IconeUrl { get; set; }
    }
}
