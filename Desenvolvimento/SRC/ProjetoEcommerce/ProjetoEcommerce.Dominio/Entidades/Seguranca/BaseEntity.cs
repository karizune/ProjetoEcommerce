using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Seguranca
{
    public class BaseEntity
    {
        public DateTime AtualizadoEm { get; set; }
        public DateTime CriadoEm { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }

    }
}
