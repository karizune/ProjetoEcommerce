using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.data.EntityFramework.Configuration
{
    class TipoCampoConfiguration : EntityTypeConfiguration<TipoCampo>
    {
        public TipoCampoConfiguration()
        {
            ToTable("TipoCampo", "Relatorio");
            HasKey(x => x.TipoCampoID);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"TipoCampoID")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Descrição)
                    .HasColumnName(@"Descricao")
                    .HasColumnType("varchar")
                    .HasMaxLength(100)
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
