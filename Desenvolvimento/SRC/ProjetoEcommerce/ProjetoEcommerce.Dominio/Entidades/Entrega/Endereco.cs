
using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Endereco : IGenerica
    {
        public int EnderecoID { get; set; }
        public int ClienteID { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        #region LOG
        public int Status { get; set ; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get ; set; }
        public DateTime AtualizaEm { get; set ; }
        #endregion
    }
}
