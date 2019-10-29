using System.Data.Entity.ModelConfiguration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;


namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class FeedbackParceiroConfiguration : EntityTypeConfiguration<FeedbackParceiro>
    {
        public FeedbackParceiroConfiguration()
        {
            ToTable("FeedbackParceiro");
            HasKey(x => x.IdFeedbackParceiro);
            Property(x => x.IdFeedbackParceiro)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Estrelas)
                .IsRequired();
            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(500);
            //FK's
            HasRequired(x => x.Parceiro)
                .WithMany()
                .HasForeignKey(p => p.IdParceiro);
            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdUsuario);

        }
    }
}
