using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Relatorio
{
    class TipoCampo : IEntidadeBase
    {
        public int TipoCampoID { get; set; }
        public string Descrição { get; set; }
        public string Usuario { get; set; }
        public int Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
