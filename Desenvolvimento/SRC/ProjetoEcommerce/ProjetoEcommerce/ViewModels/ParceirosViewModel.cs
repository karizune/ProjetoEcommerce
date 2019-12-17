using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class ParceiroViewModel
    {
        [DisplayName("ID")]
        public int IdParceiro { get; set; }
        [DisplayName("Usuario")]
        public int IdUsuario { get; set; }
        [DisplayName("Nome do Parceiro")]
        public string NomeParceiro { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [DisplayName("Telefone")]
        public string TelefoneParceiro { get; set; }
        public string TelefoneParceiro_1 { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
