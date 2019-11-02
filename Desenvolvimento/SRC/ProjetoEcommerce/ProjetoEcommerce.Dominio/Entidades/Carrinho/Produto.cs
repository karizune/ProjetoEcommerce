using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Carrinho
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int Qtde { get; set; }
    }
}
