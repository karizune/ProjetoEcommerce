﻿using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Bairro : IGenerica
    {
        public int BairroID { get; set; }
        public int CidadeID { get; set; }
        public string Nome { get; set; }
        public Cidade Cidade { get; set; }

        #region LOG

        public bool Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }

        #endregion LOG
    }
}