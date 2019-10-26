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
            ToTable("Categoria","produto");
            HasKey(x => x.CategoriaID);
            Property(x => x.CategoriaID).HasColumnName(@"CategogiaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome

            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();

            //Status

            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            //Usuario

            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm

            Property(x => x.AtualizadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
