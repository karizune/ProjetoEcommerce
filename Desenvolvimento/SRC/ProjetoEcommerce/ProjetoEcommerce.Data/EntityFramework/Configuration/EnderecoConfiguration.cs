using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("Entrega.Endereco");
            HasKey(x => x.EnderecoID);

            Property(x => x.EnderecoID)
                  .HasColumnName(@"Endereco")
                  .HasColumnType("int")
                  .IsRequired()
                  .HasDatabaseGeneratedOption
                  (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ClienteID)
                  .HasColumnName(@"ClienteID")
                  .HasColumnType("int")
                  .IsRequired()
                  .HasDatabaseGeneratedOption
                  (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CEP)
                .HasColumnName(@"CEP")
                .HasColumnType("char")
                .HasMaxLength(8)
                .IsRequired();

            Property(x => x.Numero)
                .HasColumnName(@"Numero")
                .HasColumnName("varchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(x => x.Complemento)
                .HasColumnName(@"Complemento")
                .HasColumnName("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Usuario)
               .HasColumnName(@"Usuario")
               .HasColumnType("varchar")
               .HasMaxLength(255)
               .IsRequired();

            Property(x => x.Status)
              .HasColumnName(@"Status")
              .HasColumnType("int")
              .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("Date")
                .IsRequired();

            Property(x => x.AtualizaEm)
                .HasColumnName(@"AtualizaEm")
                .HasColumnType("Date")
                .IsRequired();


        }
    }
}
