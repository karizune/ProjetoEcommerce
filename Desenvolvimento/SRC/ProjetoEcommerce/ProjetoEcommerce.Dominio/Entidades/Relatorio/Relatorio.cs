using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Relatorio
{
    class Relatorio : IEntidadeBase
    {
        public int RelatorioID { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
