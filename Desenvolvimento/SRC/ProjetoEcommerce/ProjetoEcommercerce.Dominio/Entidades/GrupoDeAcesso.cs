using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommercerce.Dominio.Entidades
{
    class GrupoDeAcesso
    {
        public int GrupoID { get; set; }
        public string Usuario { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEM { get; set; }

    }
}
