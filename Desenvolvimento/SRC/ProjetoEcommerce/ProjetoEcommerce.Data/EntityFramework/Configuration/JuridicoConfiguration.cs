using System;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class JuridicoConfiguration : EntityTypeConfiguration<Juridico>
    {
        public JuridicoConfiguration()
        {
            ToTable("Juridico", "perfil");
            HasKey(x => x.IDCliente);

            Property(x => x.IDCliente)
                .HasColumnName(@"IDCliente")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.Senha)
                .HasColumnName(@"Senha")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.Foto)
                .HasColumnName(@"Foto")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.CNPJ)
                .HasColumnName(@"CNPJ")
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            Property(x => x.InscricaoEstatual)
               .HasColumnName(@"InscricaoEstatual")
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsRequired();

            Property(x => x.Responsavel)
             .HasColumnName(@"Responsavel")
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
