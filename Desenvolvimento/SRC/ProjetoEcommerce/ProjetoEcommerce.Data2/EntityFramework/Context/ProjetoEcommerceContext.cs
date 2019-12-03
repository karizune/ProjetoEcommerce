using ProjetoEcommerce.Data2.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data2.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Rastreamento> rastreamento { get; set; }
        public DbSet<Boleto> boleto { get; set; }
        
        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["projetoEcommerceContext"].ConnectionString;
        }

        public ProjetoEcommerceContext() : base(ConnectionString())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CarteiraConfiguration());
        }
    }
}
