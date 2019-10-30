using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Boleto> Boleto { get; set; }
        public DbSet<BandeiraCartao> BandeiraCartao { get; set; }
        public DbSet<Cartao> Cartao { get; set; }
        public DbSet<Cartao_Tipo> Cartao_Tipo { get; set; }
        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<MetodoPagamento> MetodoPagamento { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<StatusCartao> StatusCartao { get; set; }
        public DbSet<StatusPagamento> StatusPagamento { get; set; }
        public DbSet<TipoCartao> TipoCartao { get; set; }

        static ProjetoEcommerceContext()
        {
            Database.SetInitializer<ProjetoEcommerceContext>(null);
        }
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ProjetoEcommerceContext"].ConnectionString;
        }
        public ProjetoEcommerceContext():base(ConnectionString())
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BoletoConfiguration());
            modelBuilder.Configurations.Add(new BandeiraCartaoConfiguration());
            modelBuilder.Configurations.Add(new CartaoConfiguration());
            modelBuilder.Configurations.Add(new Cartao_TipoConfiguration());
            modelBuilder.Configurations.Add(new CarteiraConfiguration());
            modelBuilder.Configurations.Add(new MetodoPagamentoConfiguration());
            modelBuilder.Configurations.Add(new PagamentoConfiguration());
            modelBuilder.Configurations.Add(new StatusCartaoConfiguration());
            modelBuilder.Configurations.Add(new StatusPagamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoCartaoConfiguration());

        }
    }
}
