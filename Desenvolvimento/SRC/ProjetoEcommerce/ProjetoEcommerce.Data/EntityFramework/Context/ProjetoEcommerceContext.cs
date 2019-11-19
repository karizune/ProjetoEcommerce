using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Configuration;
using System.Data.Entity;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Fisico> fisico { get; set; }
        public DbSet<Juridico> juridico { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

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
            modelBuilder.Entity<Email>().HasEntitySetName("Email");

            modelBuilder.Configurations.Add(new TelefoneConfiguration());
            modelBuilder.Entity<Telefone>().HasEntitySetName("Telefone");

            modelBuilder.Configurations.Add(new FisicoConfiguration());
            modelBuilder.Entity<Fisico>().HasEntitySetName("Fisico");

            modelBuilder.Configurations.Add(new JuridicoConfiguration());
            modelBuilder.Entity<Juridico>().HasEntitySetName("Juridico");

            modelBuilder.Configurations.Add(new SexoConfiguration());
            modelBuilder.Entity<Sexo>().HasEntitySetName("Sexo");
        }


    }
}
