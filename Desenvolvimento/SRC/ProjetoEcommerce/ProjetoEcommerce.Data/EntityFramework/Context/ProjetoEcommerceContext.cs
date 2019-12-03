using ProjetoEcommerce.Data.Configuration;
using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades;
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
        //PRODUTO
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Produto> Produto { get; set; }

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

            modelBuilder.Configurations.Add(new RastreamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoCartaoConfiguration());
            //PRODUTO
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new ImagemConfiguration());
            modelBuilder.Configurations.Add(new LojaConfiguration());
            modelBuilder.Configurations.Add(new MarcaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
    }
}
