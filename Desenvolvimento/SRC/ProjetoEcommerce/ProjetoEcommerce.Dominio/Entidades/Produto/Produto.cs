using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Produto : BaseEntity
    {
        public int ProdutoID { get; set; }
        [Display(Name = "Categorias")]
        public int CategoriaID { get; set; }
        public int ImagemID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual IEnumerable<Categoria> Categorias { get; set; }
        public virtual Imagem Imagem{get;set;}
        public virtual IEnumerable<Imagem> Imagens { get; set; }

    }
}
