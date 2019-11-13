using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    internal class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("Entrega.Endereco");
            HasKey(x => x.EnderecoID);

            Property(x => x.EnderecoID)
                  .HasColumnName(@"EnderecoID")
                  .HasColumnType("int")
                  .IsRequired()
                  .HasDatabaseGeneratedOption
                  (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ClienteID)
                  .HasColumnName(@"ClienteID")
                  .HasColumnType("int")
                  .IsRequired();

            Property(x => x.CEP)
                .HasColumnName(@"CEP")
                .HasColumnType("char")
                .HasMaxLength(8)
                .IsRequired();

            Property(x => x.Numero)
                .HasColumnName(@"Numero")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(x => x.Complemento)
                .HasColumnName(@"Complemento")
                .HasColumnType("varchar")
                .HasMaxLength(100);

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