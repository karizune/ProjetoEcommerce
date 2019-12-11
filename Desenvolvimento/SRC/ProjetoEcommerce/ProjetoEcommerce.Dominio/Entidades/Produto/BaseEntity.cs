using System;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class BaseEntity
    {
        /*Data Source=10.107.176.41;
        Initial Catalog = dbEcommerce;
        Persist Security Info=True;               
         User ID = visualstudio;
        Password=visualstudio;MultipleActiveResultSets=True" providerName="System.Data.SqlClient*/
        public DateTime AtualizadoEm { get; set; }
        public DateTime CriadoEm { get; set; }
        public int Status { get; set; }
        public string Usuario { get; set; }
    }
}
