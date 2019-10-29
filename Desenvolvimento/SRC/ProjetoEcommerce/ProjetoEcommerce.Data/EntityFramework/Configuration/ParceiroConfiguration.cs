using System.Data.Entity.ModelConfiguration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;


namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class ParceiroConfiguration : EntityTypeConfiguration<Parceiro>
    {
        public ParceiroConfiguration()
        {
            ToTable("Parceiro");
            HasKey(x => x.IdParceiro);
            Property(x => x.IdParceiro)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NomeParceiro)
                .IsRequired()
                .HasMaxLength(250);
            Property(x => x.NomeFantasia)
                .IsRequired()
                .HasMaxLength(250);
            Property(x => x.TelefoneParceiro)
                .IsRequired()
                .HasMaxLength(18);
            Property(x => x.TelefoneParceiro_1)
                .IsRequired()
                .HasMaxLength(18);

            //FK's
            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdUsuario);
        }
    }
}
