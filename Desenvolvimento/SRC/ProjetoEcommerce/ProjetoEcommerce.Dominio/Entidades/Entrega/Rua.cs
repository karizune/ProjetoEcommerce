using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Rua : IGenerica
    {
        public int RuaID { get; set; }
        public string Nome { get; set; }

        #region LOG

        public bool Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }

        #endregion LOG
    }
}