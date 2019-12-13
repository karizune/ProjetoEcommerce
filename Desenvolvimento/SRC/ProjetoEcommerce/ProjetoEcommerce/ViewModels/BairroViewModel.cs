using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels
{
    public class BairroViewModel
    {

        public int BairroID { get; set; }
        public int CidadeID { get; set; }
        public string Nome { get; set; }
        public Cidade Cidade { get; set; }

        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }

        public IEnumerable<Cidade> Cidades { get; set; }

    }
}