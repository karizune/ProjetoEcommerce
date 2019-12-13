using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class CampoRelatorioConfiguration : EntityTypeConfiguration<CampoRelatorio>
    {
        public CampoRelatorioConfiguration()
        {
            ToTable("Campo_Relatorio", "Relatorio");
            HasKey(x => new { x.RelatorioID, x.CampoID });

            Property(x => x.RelatorioID)
                .HasColumnName(@"RelatorioID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CampoID)
                .HasColumnName(@"CampoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(50)
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
