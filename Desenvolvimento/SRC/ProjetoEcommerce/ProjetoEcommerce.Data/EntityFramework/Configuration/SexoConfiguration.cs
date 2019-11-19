using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class SexoConfiguration : EntityTypeConfiguration<Sexo>
    {
        public SexoConfiguration()
        {
            ToTable("Sexo", "perfil");
            HasKey(x => new { x.IDSexo});

            Property(x => x.Nome)
               .HasColumnName(@"Nome")
               .HasColumnType("varchar")
                .HasMaxLength(50)
               .IsRequired();


            Property(x => x.Descricao)
               .HasColumnName(@"Descricao")
               .HasColumnType("varchar")
                .HasMaxLength(150)
               .IsRequired();

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
