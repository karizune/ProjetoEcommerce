using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System.Configuration;
using System.Data.Entity;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Formulario> Formulario { get; set; }
        public DbSet<FormularioGrupo> FormularioGrupo { get; set; }
        public DbSet<GrupoDeAcesso> GrupoDeAcessos { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public DbSet<Rastreamento> rastreamento { get; set; }
        public DbSet<TipoCartao> TipoCartao { get; set; }

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
            modelBuilder.Configurations.Add(new FormularioConfiguration());
            modelBuilder.Configurations.Add(new FormularioGrupoConfiguration());
            modelBuilder.Configurations.Add(new GrupoDeAcessoConfiguration());
            modelBuilder.Configurations.Add(new GrupoUsuarioConfiguration());
            modelBuilder.Configurations.Add(new RastreamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoCartaoConfiguration());
        }
    }
}
