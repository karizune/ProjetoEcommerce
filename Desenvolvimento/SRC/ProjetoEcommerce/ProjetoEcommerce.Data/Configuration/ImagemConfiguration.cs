using ProjetoEcommerce.Dominio.Entidades.Produto;
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
            ToTable("Imagem");
            HasKey(x => x.ImagemID);
            Property(x => x.ImagemID).HasColumnName(@"ImagemID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            ToTable("Imagem");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();
            //URL
            ToTable("Imagem");
            HasKey(x => x.URL);
            Property(x => x.URL).HasColumnName(@"URL").HasColumnType("varchar").IsRequired();
            //Tamanho
            ToTable("Imagem");
            HasKey(x => x.Tamanho);
            Property(x => x.Tamanho).HasColumnName(@"Tamanho").HasColumnType("real").IsRequired();

            //Status
            ToTable("Imagem");
            HasKey(x => x.Status);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsRequired();
            //Usuario
            ToTable("Imagem");
            HasKey(x => x.Usuario);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            ToTable("Imagem");
            HasKey(x => x.CriadoEm);
            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            ToTable("Imagem");
            HasKey(x => x.AtualizadoEm);
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
