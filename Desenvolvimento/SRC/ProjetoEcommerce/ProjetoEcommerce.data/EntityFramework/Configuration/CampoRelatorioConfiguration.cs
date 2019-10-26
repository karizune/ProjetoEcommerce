using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.data.EntityFramework.Configuration
{
    public class CampoRelatorioConfiguration : EntityTypeConfiguration<CampoRelatorio>
    {
        public CampoRelatorioConfiguration()
        {
            ToTable("Relatorio.Campo_Relatorio");
            HasKey(x => x.RelatorioID);
            HasKey(x => x.CampoID);

            Property(x => x.RelatorioID)
                .HasColumnName(@"RelatorioID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CampoID)
                .HasColumnName(@"CampoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar(50)")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.AtualizadoEm)
                .HasColumnName(@"AtualizadoEm")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
