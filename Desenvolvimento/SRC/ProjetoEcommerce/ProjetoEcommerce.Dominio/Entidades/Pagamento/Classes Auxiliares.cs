using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Pagamento
{
    public class Usuario : BaseEntity
    {
            public int ID;
            public string Nome;
    }
    public class ProdutoCarrinho : BaseEntity
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string DescricaoProduto { get; set; }
        public string UrlImagem { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public float PrecoTotal
        {
            get
            {
                return Preco * Quantidade;
            }
        }
    }
}
