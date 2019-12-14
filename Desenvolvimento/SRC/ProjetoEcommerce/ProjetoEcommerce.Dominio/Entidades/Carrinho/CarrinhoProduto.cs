using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Carrinho
{
    public class CarrinhoProduto
    {
        //PROPERTIES
        public int CarrinhoID { get; set; }
        public int UsuarioID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }

        //LOG
        public int Status{ get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Produto Produto { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
