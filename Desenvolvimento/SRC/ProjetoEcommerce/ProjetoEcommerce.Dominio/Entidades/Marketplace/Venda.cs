using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class Venda
    {
        public Venda()
        {
            this.Rastreios = new HashSet<Rastreio>();
        }
        //TEMPORARIO SOMENTE PARA NÃO DAR ERRO !!!
        [Key]
        public int IdVenda { get; set; }
        public virtual ICollection<Rastreio> Rastreios { get; set; }
    }
}
