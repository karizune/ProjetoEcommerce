using ProjetoEcommerce.Data.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext:DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Produto> Produto { get; set; }

        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["projetoEcommerceContext"].ConnectionString;
        }
        public ProjetoEcommerceContext():base(ConnectionString())
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new ImagemConfiguration());
            modelBuilder.Configurations.Add(new LojaConfiguration());
            modelBuilder.Configurations.Add(new MarcaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
    }
}
