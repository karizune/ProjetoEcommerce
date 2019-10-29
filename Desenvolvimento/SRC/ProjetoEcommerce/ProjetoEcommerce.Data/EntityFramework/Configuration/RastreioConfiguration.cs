using System.Data.Entity.ModelConfiguration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;


namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class RastreioConfiguration : EntityTypeConfiguration<Rastreio>
    {
        public RastreioConfiguration()
        {
            ToTable("Ratreio");
            HasKey(x => x.IdRastreio);
            Property(x => x.IdRastreio)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoRastreio)
                .IsRequired()
                .HasMaxLength(40);
            Property(x => x.CodigoPacote)
                .IsRequired()
                .HasMaxLength(40);
            Property(x => x.DestinatarioRastreio)
                .IsRequired()
                .HasMaxLength(150);
        }

    }
}
