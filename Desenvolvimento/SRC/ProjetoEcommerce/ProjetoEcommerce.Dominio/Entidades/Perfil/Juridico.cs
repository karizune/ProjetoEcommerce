using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public class Juridico : Cliente
    {
        public int IDCliente { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstatual { get; set; }
        public string Responsavel { get; set; }

    }
}
