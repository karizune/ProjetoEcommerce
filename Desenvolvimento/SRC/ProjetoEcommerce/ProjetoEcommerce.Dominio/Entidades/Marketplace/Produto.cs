using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Marketplace
{
    public class Produto
    {
        //TEMPORARIO SOMENTE PARA NÃO DAR ERRO !!!
        [Key]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
    }
}
