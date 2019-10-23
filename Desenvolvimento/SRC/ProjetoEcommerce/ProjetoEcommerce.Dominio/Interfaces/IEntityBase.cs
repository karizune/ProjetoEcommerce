using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces
{
    public interface IEntityBase
    {
        int Status { get; set; }
        string Usuario { get; set; }
        DateTime CriadoEm { get; set; }
        DateTime AtualizadoEm { get; set; }
    }
}
