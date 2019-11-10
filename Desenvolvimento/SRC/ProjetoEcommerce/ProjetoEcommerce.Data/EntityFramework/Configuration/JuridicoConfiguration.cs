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
            HasKey(x => new { x.IDCliente });


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
        }
    }
}
