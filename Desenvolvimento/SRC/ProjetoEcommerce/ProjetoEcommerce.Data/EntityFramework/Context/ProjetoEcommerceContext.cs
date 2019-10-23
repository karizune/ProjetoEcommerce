using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Fisico> fisico { get; set; }
        public DbSet<Juridico> juridico { get; set; }

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

            modelBuilder.Configurations.Add(new ClienteConfiguration());
        }


    }
}
