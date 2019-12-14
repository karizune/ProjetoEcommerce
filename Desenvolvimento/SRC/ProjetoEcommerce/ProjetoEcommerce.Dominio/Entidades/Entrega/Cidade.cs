﻿using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Cidade : IGenerica
    {
        public int CidadeID { get; set; }
        public string Nome { get; set; }
        public int EstadoID { get; set; }

        public Estado Estado { get; set; }

        #region LOG

        public bool Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }

        #endregion LOG
    }
}