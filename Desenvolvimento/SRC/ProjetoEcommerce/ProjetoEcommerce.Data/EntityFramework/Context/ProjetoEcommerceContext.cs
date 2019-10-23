using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEcommerce.Dominio.Entidades.Entrega;

namespace ProjetoEcommerce.Data.EntityFramework.Context
{
    class ProjetoEcommerceContext : DbContext
    {
        public DbSet<Bairro> bairro { get; set; }
        public DbSet<Ceps> ceps { get; set; }
        public DbSet<Cidade> cidade { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<Estado> estado { get; set; }
        public DbSet<Rua> rua { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configuration.Add(new BairroConfiguration
        }
    }
}
