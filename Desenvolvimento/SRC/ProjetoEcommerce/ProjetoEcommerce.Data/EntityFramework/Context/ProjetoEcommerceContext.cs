using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Entrega;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System.Configuration;
using System.Data.Entity;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Rastreamento> rastreamento { get; set; }
        public DbSet<TipoCartao> TipoCartao { get; set; }

        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Ceps> Ceps { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Rua> Rua { get; set; }

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

            modelBuilder.Configurations.Add(new BairroConfiguration());
            modelBuilder.Configurations.Add(new CepsConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new RuaConfiguration());

            modelBuilder.Configurations.Add(new RastreamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoCartaoConfiguration());
        }
    }
}
