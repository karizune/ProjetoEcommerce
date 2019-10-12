namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Carteira : BaseEntity
    {
        public int CarteiraID { get; set; }
        public decimal Saldo { get; set; }
	public int UsuarioID { get; set; }
        
    }
}
