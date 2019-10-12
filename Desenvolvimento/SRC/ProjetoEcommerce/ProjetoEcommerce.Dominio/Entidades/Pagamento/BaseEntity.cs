using System;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class BaseEntity
    {
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }
    }
}
