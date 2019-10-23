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
            ToTable("Boleto");
            HasKey(x => x.BoletoID);
            Property(x => x.BoletoID).HasColumnName(@"BoletoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}
