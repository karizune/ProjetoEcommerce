using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System.Configuration;
using System.Data.Entity;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Rastreamento> rastreamento { get; set; }

        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }

        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        }

        public ProjetoEcommerceContext() : base(ConnectionString())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RastreamentoConfiguration());
        }
    }
}
