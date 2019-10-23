using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class CepsConfiguration : EntityTypeConfiguration<Ceps>
    {
        public CepsConfiguration()
        {

            ToTable("Ceps");
            HasKey(x => x.CEP);

            Property(x => x.BairroID)
                .HasColumnName(@"CEP")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}
