using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Configuration
{
    class ProdutoConfiguration: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            //ProdutoID
            ToTable("Produto","produto");
            HasKey(x => x.ProdutoID);
            Property(x => x.ProdutoID).HasColumnName(@"ProdutoID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //CategoriaID
            Property(x => x.CategoriaID).HasColumnName(@"CategoriaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();
            //Preco
            Property(x => x.Preco).HasColumnName(@"Preco").HasColumnType("double").IsRequired();

            //Status
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            //Usuario
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
