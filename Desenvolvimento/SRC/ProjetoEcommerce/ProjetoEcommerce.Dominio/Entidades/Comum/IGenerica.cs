using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Comum
{
    public interface IGenerica
    {
        int Status { get; set; }
        string Usuario { get; set; }
        DateTime CriadoEm { get; set; }
        DateTime AtualizaEm { get; set; }
    }
}
