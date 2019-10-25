using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommercerce.Dominio.Entidades
{
    class Formulario
    {
        public int FormularioID { get; set; }
        public string Descricao { get; set; }
        public string URL { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEM { get; set; }
    }
}
