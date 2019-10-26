using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Configuration
{
    public class CategoriaConfiguration:EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            //CategoriaID
            ToTable("Categoria");
            HasKey(x => x.CategoriaID);
            Property(x => x.CategoriaID).HasColumnName(@"CategogiaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            ToTable("Categoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();

            //Status
            ToTable("Categoria");
            HasKey(x => x.Status);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsRequired();
            //Usuario
            ToTable("Categoria");
            HasKey(x => x.Usuario);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            ToTable("Categoria");
            HasKey(x => x.AtualizadoEm);
            Property(x => x.AtualizadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            ToTable("Categoria");
            HasKey(x => x.AtualizadoEm);
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
