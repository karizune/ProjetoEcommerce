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
            HasKey(x => new { x.IDTelefone, x.IDCliente });

            Property(x => x.IDTelefone)
               .HasColumnName(@"IDTelefone")
               .HasColumnType("int")
               .IsRequired()
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.IDCliente)
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

            Property(x => x.Status)
               .HasColumnName(@"Senha")
               .HasColumnType("bit")
               .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
