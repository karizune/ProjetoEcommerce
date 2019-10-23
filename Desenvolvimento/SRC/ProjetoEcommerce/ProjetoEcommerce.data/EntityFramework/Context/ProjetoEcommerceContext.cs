using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.data.EntityFramework.Context
{
    public class ProjetoEcommerceContext: DbContext
  
    {
        public DbSet<Campo> campo { get; set; }
        public DbSet<CampoRelatorio> campoRelatori { get; set; }
        public DbSet<Relatorio> relatorio { get; set; }
        public DbSet<TipoCampo> TipoCampo { get; set; }

        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }
        
        private static string ConnectionsString ()
        {
            return ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        }
        public ProjetoEcommerceContext() : base(ConnectionsString())
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Configurations.Add(new RastrementoConfiguration());
        }
    }
}
