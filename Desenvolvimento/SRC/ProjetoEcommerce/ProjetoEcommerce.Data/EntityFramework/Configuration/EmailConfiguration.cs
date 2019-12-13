using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class EmailConfiguration :EntityTypeConfiguration<Email>
    {
        public EmailConfiguration()
        {
            ToTable("Email","perfil");
            HasKey(x => new { x.IDEmail, x.ClienteId });

            Property(x => x.IDEmail)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ClienteId)
                .HasColumnName(@"IDCliente")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.E_mail)
                .HasColumnName(@"E_mail")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("bit")
                .IsRequired();

            HasRequired(x => x.CLiente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

            Property(x => x.Status)
               .HasColumnName(@"Status")
               .HasColumnType("bit")
               .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(100)
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
