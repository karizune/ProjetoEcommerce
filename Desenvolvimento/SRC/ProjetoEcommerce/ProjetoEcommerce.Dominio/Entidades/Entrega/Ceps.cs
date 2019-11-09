using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega
{
    public class Ceps : IGenerica
    {
        public string CEP { get; set; }
        public int EstadoID { get; set; }
        public int CidadeID { get; set; }
        public int BairroID { get; set; }
        public int RuaID { get; set; }

        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
        public Bairro Bairro { get; set; }
        public Rua Rua { get; set; }

        #region LOG

        public int Status { get; set; }
        public string Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizaEm { get; set; }

        #endregion LOG
    }
}