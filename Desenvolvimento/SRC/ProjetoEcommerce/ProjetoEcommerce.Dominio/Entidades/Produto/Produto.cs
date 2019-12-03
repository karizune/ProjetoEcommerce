using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Produto : BaseEntity
    {
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public int ImagemID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
