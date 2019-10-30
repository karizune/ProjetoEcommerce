using System;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Boleto : BaseEntity
    {
        public int BoletoID { get; set; }
        public string CodigoBanco { get; set; }
        public string LinhaDigitavel { get; set; }
        public DateTime Vencimento { get; set; }
        public string AgenciaCodigoCedente { get; set; }
        public string NossoNumero { get; set; }
        public decimal Valor { get; set; }
        public string Carteira { get; set; }
        public string Pagador { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Cedente { get; set; }
    }
}
