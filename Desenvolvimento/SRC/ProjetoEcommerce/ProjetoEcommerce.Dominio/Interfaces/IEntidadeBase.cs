using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces
{
    public interface IEntidadeBase
    {
         string Usuario { get; set; }
         int Status { get; set; }
         DateTime CriadoEm { get; set; }
         DateTime AtualizadoEm { get; set; }
    }
}
