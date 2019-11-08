using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Relatorio
{
    public class Registro : IEntidadeBase
    {
        public int RelatorioID { get; set; }
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public int Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
