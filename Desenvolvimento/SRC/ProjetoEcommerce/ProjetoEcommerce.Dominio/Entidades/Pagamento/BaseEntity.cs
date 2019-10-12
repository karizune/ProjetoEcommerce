using System;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class BaseEntity
    {
        public DateTime AtualizadoEm { get; set; }
        public DateTime CriadoEm { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }
    }
}
