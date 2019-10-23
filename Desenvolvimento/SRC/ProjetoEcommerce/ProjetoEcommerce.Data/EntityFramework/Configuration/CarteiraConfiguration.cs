using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class CarteiraConfiguration : EntityTypeConfiguration<Carteira>
    {
        public CarteiraConfiguration()
        {
            ToTable("Carteira");
            HasKey(x => x.CarteiraID);

            Property(x => x.CarteiraID)
                .HasColumnName(@"CarteiraID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
           
        }
    }
}
