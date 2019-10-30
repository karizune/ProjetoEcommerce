namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{

    public struct Usuario
    {
        public int ID;
        public string Nome;
    }
    public class Carteira : BaseEntity
    {
        public int CarteiraID { get; set; }
        public decimal Saldo { get; set; }
	    public int UsuarioID { get; set; }
        public Usuario usuario { get; set; }
    }
}
