using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Loja : BaseEntity
    {
        public int LojaID { get; set; }
        public string Nome { get; set; }
    }
}
