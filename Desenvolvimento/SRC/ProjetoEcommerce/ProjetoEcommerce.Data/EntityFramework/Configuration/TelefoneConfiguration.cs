using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class TelefoneConfiguration : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfiguration()
        {
            ToTable("Telefone","perfil");
            HasKey(x => new { x.IDTelefone, x.ClienteId });

            Property(x => x.IDTelefone)
               .HasColumnName(@"IDTelefone")
               .HasColumnType("int")
               .IsRequired()
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ClienteId)
               .HasColumnName(@"IDCliente")
               .HasColumnType("int")
               .IsRequired();

            Property(x => x.Numero)
              .HasColumnName(@"Numero")
              .HasColumnType("varchar")
              .IsRequired();

            Property(x => x.DDD)
              .HasColumnName(@"DDD")
              .HasColumnType("varchar")
              .IsRequired();


            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            HasRequired(x => x.cliente)
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
