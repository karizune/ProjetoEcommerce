using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.data.EntityFramework.Configuration
{
    public class CampoConfiguration : EntityTypeConfiguration<Campo>
    {
        public CampoConfiguration()
        {
            ToTable("Relatorio.Campo");
            HasKey(x => x.CampoID);

            Property(x => x.CampoID)
                .HasColumnName(@"CampoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

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

            Property(x => x.TipoCampoID)
                .HasColumnName(@"TipoCampoID")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
