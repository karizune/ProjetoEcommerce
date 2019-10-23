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
        public DbSet<MetodoPagamento> MetodoPagamentos { get; set; }
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
            return ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        }
        public ProjetoEcommerceContext():base(ConnectionString())
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
