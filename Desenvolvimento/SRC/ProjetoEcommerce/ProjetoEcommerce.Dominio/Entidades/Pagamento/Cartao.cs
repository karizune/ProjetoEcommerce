using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Cartao : BaseEntity
    {
        public int CartaoID { get; set; }
        [CreditCard (ErrorMessage = "Insira um cartão válido")]
        public string Numero { get; set; }
        public DateTime Vencimento { get; set; }
        public int UsuarioID { get; set; }
        public string NomeTitular { get; set; }
        public int BandeiraCartaoID { get; set; }
        public int StatusCartaoID { get; set; }

        public BandeiraCartao bandeiraCartao { get; set; }
        public StatusCartao statusCartao { get; set; }
    }
}
