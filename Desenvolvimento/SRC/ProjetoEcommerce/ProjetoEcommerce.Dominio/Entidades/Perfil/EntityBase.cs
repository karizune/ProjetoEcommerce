using System;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public abstract class EntityBase
    {
        public bool Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}