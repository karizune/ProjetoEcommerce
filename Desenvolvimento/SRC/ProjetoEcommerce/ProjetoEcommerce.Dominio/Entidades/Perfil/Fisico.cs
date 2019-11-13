using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
   public class Fisico : Cliente
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IDSexo { get; set; }
        public virtual Sexo Sexo { get; set; }

     
    }
}
