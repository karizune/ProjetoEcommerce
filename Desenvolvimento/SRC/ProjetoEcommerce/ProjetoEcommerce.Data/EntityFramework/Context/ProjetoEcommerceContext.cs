using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Carrinho;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Carrinho> carrinho { get; set; }
        public DbSet<CarrinhoProduto> carrinhoProduto { get; set; }

        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ProjetoEcommerceContext"].ConnectionString;
        }

        public ProjetoEcommerceContext() : base(ConnectionString())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CarrinhoConfiguration());
            modelBuilder.Configurations.Add(new CarrinhoProdutoConfiguration());
        }
    }
}
