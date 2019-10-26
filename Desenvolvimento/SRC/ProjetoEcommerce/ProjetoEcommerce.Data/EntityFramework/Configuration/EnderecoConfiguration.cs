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
                .HasColumnName(@"EnderecoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ClienteID)
                .HasColumnName(@"ClienteID")
                .HasColumnName("int")
                .IsRequired();

            Property(x => x.CEP)
                .HasColumnName(@"CEP")
                .HasColumnName("varchar")
                .HasMaxLength(8)
                .IsRequired();

            Property(x => x.Numero)
                .HasColumnName(@"Numero")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();

        }
    }
}
