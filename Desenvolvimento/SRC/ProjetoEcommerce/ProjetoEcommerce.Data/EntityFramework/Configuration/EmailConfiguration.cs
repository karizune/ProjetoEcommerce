using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class EmailConfiguration :EntityTypeConfiguration<Email>
    {
        public EmailConfiguration()
        {
            ToTable("Email");
            HasKey(x => x.IDEmail);
            HasKey(x => x.IDCliente);

            Property(x => x.IDEmail)
                .HasColumnName(@"IDEmail")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.IDCliente)
                .HasColumnName(@"IDCliente")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Senha")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
