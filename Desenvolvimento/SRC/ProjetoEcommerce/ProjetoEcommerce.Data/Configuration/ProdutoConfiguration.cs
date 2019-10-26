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
            ToTable("Produto");
            HasKey(x => x.ProdutoID);
            Property(x => x.ProdutoID).HasColumnName(@"ProdutoID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //CategoriaID
            ToTable("Produto");
            HasKey(x => x.CategoriaID);
            Property(x => x.CategoriaID).HasColumnName(@"CategoriaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            ToTable("Produto");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();
            //Preco
            ToTable("Produto");
            HasKey(x => x.Preco);
            Property(x => x.Preco).HasColumnName(@"Preco").HasColumnType("double").IsRequired();

            //Status
            ToTable("Produto");
            HasKey(x => x.Status);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            //Usuario
            ToTable("Produto");
            HasKey(x => x.Usuario);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            ToTable("Produto");
            HasKey(x => x.CriadoEm);
            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            ToTable("Produto");
            HasKey(x => x.AtualizadoEm);
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
