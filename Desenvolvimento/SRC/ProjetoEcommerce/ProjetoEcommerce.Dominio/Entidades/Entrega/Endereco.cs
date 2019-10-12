
using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    class Endereco : IGenerica
    {
        public int EnderecoID { get; set; }
        public int ClienteID { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public int Status { get; set ; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get ; set; }
        public DateTime AtualizaEm { get; set ; }
    }
}
