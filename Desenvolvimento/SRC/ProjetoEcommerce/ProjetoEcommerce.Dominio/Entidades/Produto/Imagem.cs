using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Produto
{
    public class Imagem:IEntityBase
    {  
        public int ImagemID { get; set; }
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public double Tamanho { get; set; }
        //LOG
        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Produto Produto { get; set; }
    }
}
