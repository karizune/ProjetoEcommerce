using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class CartaoConfiguration : EntityTypeConfiguration<Cartao>
    {
        public CartaoConfiguration()
        {
            ToTable("Cartao", "pagamento");
            HasKey(x => x.CartaoID);
            Property(x => x.CartaoID)
                .HasColumnName(@"CartaoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.NomeTitular)
                .HasColumnName(@"NomeTitular")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Numero).HasColumnName(@"Numero").HasColumnType("varchar").HasMaxLength(16).IsRequired();

            Property(x => x.VencimentoMes).HasColumnName("VencimentoMes").HasColumnType("int").IsRequired();
            Property(x => x.VencimentoAno).HasColumnName("VencimentoAno").HasColumnType("int").IsRequired();
            Property(x => x.BandeiraCartaoID).HasColumnName(@"BandeiraCartaoID").HasColumnType("int").IsRequired();
            Property(x => x.StatusCartaoID).HasColumnName("@StatusCartaoID").HasColumnType("int").IsRequired();
            Property(x => x.UsuarioID).HasColumnName(@"UsuarioID").HasColumnType("int").IsRequired();

            Property(x => x.AtualizadoEm)
                .HasColumnName(@"AtualizadoEm")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
