using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    internal class BairroConfiguration : EntityTypeConfiguration<Bairro>
    {
        public BairroConfiguration()
        {
            ToTable("Entrega.Bairro");
            HasKey(x => x.BairroID);

            Property(x => x.BairroID)
                .HasColumnName(@"BairroID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CidadeID)
                .HasColumnName(@"CidadeID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("Date");

            Property(x => x.AtualizaEm)
                .HasColumnName(@"AtualizaEm")
                .HasColumnType("Date");
        }
    }
}