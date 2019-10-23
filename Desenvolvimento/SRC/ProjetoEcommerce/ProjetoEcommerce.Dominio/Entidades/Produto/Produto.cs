using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Produto
{
    public class Produto
    {
        //LOG
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        //
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
