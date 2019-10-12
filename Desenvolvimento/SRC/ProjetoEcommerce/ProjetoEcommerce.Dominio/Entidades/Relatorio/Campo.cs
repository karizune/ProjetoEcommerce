﻿using ProjetoEcommerce.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades.Relatorio
{
    public class Campo : IEntidadeBase
    {
        public int CampoID { get; set; }
        public string Nome { get; set; }
        public int TipoCampoID { get; set; }
        public string Usuario { get; set; }
        public int Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }


    }
}
