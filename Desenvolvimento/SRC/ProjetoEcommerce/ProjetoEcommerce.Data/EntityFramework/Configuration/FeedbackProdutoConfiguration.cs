using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class FeedbackProdutoConfiguration : EntityTypeConfiguration<FeedbackProduto>
    {
        public FeedbackProdutoConfiguration()
        {
            ToTable("FeedbackProduto");
            HasKey(x => x.IdFeedbackProduto);
            Property(x => x.IdFeedbackProduto)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Estrelas)
                .IsRequired();
            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(500);
            //FK's
            HasRequired(x => x.Produto)
                .WithMany()
                .HasForeignKey(p => p.IdProduto);
            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdUsuario);
        }
    }
}
