using ProjetoEcommerce.data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System.Configuration;
using System.Data.Entity;

namespace ProjetoEcommerce.data.EntityFramework.Context
{
    public class ProjetoEcommerceContext: DbContext
  
    {
        public DbSet<Campo> Campo { get; set; }
        public DbSet<CampoRelatorio> CampoRelatorio { get; set; }
        public DbSet<Registro> Registro { get; set; }
        public DbSet<TipoCampo> TipoCampo { get; set; }
        public DbSet<Relatorio> Relatorio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

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
            modelBuilder.Configurations.Add(new CampoConfiguration());
        }
    }
}
