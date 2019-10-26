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
            ToTable("Cateoria");
            HasKey(x => x.CategoriaID);
            Property(x => x.CategoriaID).HasColumnName(@"CategogiaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            ToTable("Cateoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();

            //Status
            ToTable("Cateoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Status").HasColumnType("varchar").IsRequired();
            //Usuario
            ToTable("Cateoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            ToTable("Cateoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"CriadoEm").HasColumnType("varchar").IsRequired();
            //AtualizadoEm
            ToTable("Cateoria");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"AtualizadoEm").HasColumnType("date").IsRequired();
        }
    }
}
