using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class ParceiroViewModel
    {
        public int IdParceiro { get; set; }
        public int IdUsuario { get; set; }
        public string NomeParceiro { get; set; }
        public string NomeFantasia { get; set; }
        public string TelefoneParceiro { get; set; }
        public string TelefoneParceiro_1 { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
