using System;

namespace ProjetoEcommerce.Dominio.Entidades.Comum
{
    public interface IGenerica
    {
        bool Status { get; set; }
        string Usuario { get; set; }
        DateTime CriadoEm { get; set; }
        DateTime AtualizaEm { get; set; }
    }
}