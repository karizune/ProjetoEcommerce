using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Imagem : BaseEntity
    {
        public int ImagemID { get; set; }
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public decimal Tamanho { get; set; }
    }
}
