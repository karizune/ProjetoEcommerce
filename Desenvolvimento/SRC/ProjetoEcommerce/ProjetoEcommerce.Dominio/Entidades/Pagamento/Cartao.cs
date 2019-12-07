using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Cartao : BaseEntity
    {
        public int CartaoID { get; set; }
        //[CreditCard (ErrorMessage = "Insira um cartão válido")]
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public int UsuarioID { get; set; }
        public string NomeTitular { get; set; }
        public int BandeiraCartaoID { get; set; }
        public string CVC { get; set; }
    }
}
