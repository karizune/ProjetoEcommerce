using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class PagamentoConfiguration : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoConfiguration()
        {
            ToTable("Pagamento", "pagamento");
            HasKey(x => x.PagamentoID);
            Property(x => x.PagamentoID).HasColumnName(@"PagamentoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //
            Property(x => x.BoletoID).HasColumnName(@"BoletoID").HasColumnType("int").IsOptional();
            Property(x => x.CartaoID).HasColumnName(@"CartaoID").HasColumnType("int").IsOptional();
            //
            Property(x => x.UsuarioID).HasColumnName(@"UsuarioID").HasColumnType("int").IsRequired();
            Property(x => x.ValorTotal).HasColumnName(@"ValorTotal").HasColumnType("decimal").IsRequired();
            Property(x => x.StatusPagamentoID).HasColumnName(@"StatusPagamentoID").HasColumnType("int").IsRequired();
            Property(x => x.NroParcelamento).HasColumnName(@"NroParcelamento").HasColumnType("int").IsRequired();
            Property(x => x.MetodoPagamentoID).HasColumnName(@"MetodoPagamentoID").HasColumnType("int").IsRequired();
            

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
