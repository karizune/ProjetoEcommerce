using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Cidade : IGenerica
    {
        public int CidadeID { get; set; }
        public string Nome { get; set; }
        public int EstadoID { get; set; }

        public Estado Estado { get; set; }

        #region LOG
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }
        #endregion

    }
}
