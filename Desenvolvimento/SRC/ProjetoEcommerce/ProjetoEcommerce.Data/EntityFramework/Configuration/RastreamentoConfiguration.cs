using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class RastreamentoConfiguration : EntityTypeConfiguration<Rastreamento>
    {
        public RastreamentoConfiguration()
        {
            ToTable("Rastreamento");
            HasKey(x => x.RastreamentoID);

            Property(x => x.RastreamentoID).HasColumnName(@"RastreamentoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Property(x => x.Identificador).HasColumnName(@"Identificador").HasColumnType("varchar").IsRequired().HasMaxLength(36);
            //Property(x => x.DataTermino).HasColumnName(@"DataTermino").HasColumnType("datetime").IsRequired();
            //Property(x => x.ValorParcela).HasColumnName(@"ValorParcela").HasColumnType("numeric").HasPrecision(15, 4);
            //Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();

        }
    }
}
