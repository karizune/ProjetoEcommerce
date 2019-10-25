using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class BoletoConfiguration : EntityTypeConfiguration<Boleto>
    {
        public BoletoConfiguration()
        {
            ToTable("Boleto","pagamento");
            HasKey(x => x.BoletoID);
            Property(x => x.BoletoID)
                .HasColumnName(@"BoletoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.AgenciaCodigoCedente).HasColumnName("AgenciaCodigoCedente").HasColumnType("varchar(6)").IsRequired();
            Property(x => x.Carteira).HasColumnName("Carteira").HasColumnType("char").IsRequired();
            Property(x => x.Cedente).HasColumnName("Cedente").HasColumnType("varchar(50)").IsRequired();
            Property(x => x.CodigoBanco).HasColumnName("CodigoBanco").HasColumnType("varchar(4)").IsRequired();
            Property(x => x.DataDocumento).HasColumnName("DataDocumento").HasColumnType("datetime").IsRequired();
            Property(x => x.LinhaDigitavel).HasColumnName("LinhaDigitavel").HasColumnType("varchar(44)").IsRequired();
            Property(x => x.NossoNumero).HasColumnName("NossoNumero").HasColumnType("varchar(10)").IsRequired();
            Property(x => x.Pagador).HasColumnName("Pagador").HasColumnType("varchar(50)").IsRequired();
            Property(x => x.Valor).HasColumnName("Valor").HasColumnType("decimal").IsRequired();
            Property(x => x.Vencimento).HasColumnName("Vencimento").HasColumnType("datetime").IsRequired();
            


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
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
