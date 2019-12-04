using ProjetoEcommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Configuration
{
    public class ImagemConfiguration : EntityTypeConfiguration<Imagem>
    {
        public ImagemConfiguration()
        {
            //ImagemID
            ToTable("Imagem", "produto");
            HasKey(x => x.ImagemID);
            Property(x => x.ImagemID).HasColumnName(@"ImagemID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();
            Property(x => x.URL).HasColumnName(@"URL").HasColumnType("varchar").IsRequired();
            Property(x => x.Tamanho).HasColumnName(@"Tamanho").HasColumnType("numeric").IsRequired();

            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
