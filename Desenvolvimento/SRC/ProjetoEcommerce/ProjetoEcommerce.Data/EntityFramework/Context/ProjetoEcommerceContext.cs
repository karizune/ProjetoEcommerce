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
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Fisico> fisico { get; set; }
        public DbSet<Juridico> juridico { get; set; }

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

            modelBuilder.Configurations.Add(new EmailConfiguration());
            modelBuilder.Entity<Cliente>().HasEntitySetName("Email");

            modelBuilder.Configurations.Add(new TelefoneConfiguration());
            modelBuilder.Entity<Cliente>().HasEntitySetName("Telefone");

            modelBuilder.Configurations.Add(new FisicoConfiguration());
            modelBuilder.Entity<Cliente>().HasEntitySetName("Fisico");

            modelBuilder.Configurations.Add(new JuridicoConfiguration());
            modelBuilder.Entity<Cliente>().HasEntitySetName("Juridico");

            modelBuilder.Configurations.Add(new SexoConfiguration());
            modelBuilder.Entity<Cliente>().HasEntitySetName("Sexo");
        }


    }
}
