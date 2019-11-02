using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class FormularioConfiguration : EntityTypeConfiguration<Formulario>
    {
        public FormularioConfiguration()
        {
            ToTable("Formulario", "seguranca");
            HasKey(x => x.FormularioID);

            Property(x => x.FormularioID)
                .HasColumnName(@"FormularioID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .HasColumnName(@"Descricao")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(100);


            Property(x => x.URL)
                .HasColumnName(@"URL")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(100);

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
