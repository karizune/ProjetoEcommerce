using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Carrinho
{
    public class Carrinho
    {
        //PROPERTIES
        public int CarrinhoID { get; set; }
        public int UsuarioID { get; set; }
        public int EnderecoID { get; set; }
        public decimal PrecoTotal { get; set; }
        public decimal PrecoFrete { get; set; }

        //LOG
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }


        public Usuario User { get; set; } // MUDAR PARA A CLASSE DEPOIS
        public Endereco Endereco { get; set; } // MUDAR PARA A CLASSE DEPOIS

    }
}
