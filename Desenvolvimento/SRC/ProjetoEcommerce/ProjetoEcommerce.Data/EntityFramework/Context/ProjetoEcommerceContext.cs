using ProjetoEcommerce.Data.EntityFramework.Configuration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Service;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Unity.Injection;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    public class ProjetoEcommerceContext : DbContext
    {
        public ProjetoEcommerceContext() : base("ProjetoEcommerce") { }
        
        public DbSet <Rastreio> Rastreio { get; set; }
        public DbSet <Parceiro> Parceiro { get; set; }
        public DbSet <FeedbackParceiro> FeedbackParceiro { get; set; }
        public DbSet<FeedbackProduto> FeedbackProduto { get; set; }
        public DbSet <Usuario> Usuario { get; set; }
        public DbSet <Venda> Venda { get; set; }
        public DbSet <Produto> Produto { get; set; }

        /*
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
        */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Removendo colocar no plural tabelas e deletar em cascata
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //String sera varchar com tamanho de 100 ao invez de anyvarchar no banco

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //se for definido algo differente nas configurações a baixo as de cima n atraparalhao
            modelBuilder.Configurations.Add(new RastreioConfiguration());
            modelBuilder.Configurations.Add(new FeedbackParceiroConfiguration());
            modelBuilder.Configurations.Add(new ParceiroConfiguration());
            modelBuilder.Configurations.Add(new FeedbackProdutoConfiguration());


            //base.OnModelCreating(modelBuilder);
        }


        //DATETIME.NOW NAS DATAS DE CADASTRO
        public override int SaveChanges()
        {
            //AQUI VERIFICAMOS SEMPLRE QUE ELE ESTIVER BUSCANDO MUDANÇAS, ONDE A ENTIDADE FOR NOMEADA COMO "DataCadastro"
            //E FOR DIFERENTE DE NULL
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    //AQUI ELE VERIFICA SE E UMA ADIÇÃO SE SIM ELE ADICIONA O DATETIME.NOW NO CAMPO
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    //AQUI ELE VERIFICA SE E SOMENTE UMA ALTERAÇÃO E MANTERA A DATA DE CADASTRO
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
