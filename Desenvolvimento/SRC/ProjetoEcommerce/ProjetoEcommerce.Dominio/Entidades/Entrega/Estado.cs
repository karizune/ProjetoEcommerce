using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    class Estado
    {
        public int ID { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Status { get; set; }
    }
}
