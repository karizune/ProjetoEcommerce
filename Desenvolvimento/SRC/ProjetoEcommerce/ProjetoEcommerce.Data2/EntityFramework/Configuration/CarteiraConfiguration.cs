using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data2.EntityFramework.Configuration
{
    public class CarteiraConfiguration : EntityTypeConfiguration<Carteira>
    {
        public CarteiraConfiguration()
        {
            ToTable("Carteira");
            HasKey(x => x.CarteiraID);
            //HasKey(x => new { x.CarteiraID, x.UsuarioID } );

            Property(x => x.CarteiraID)
                .HasColumnName(@"CarteiraID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Saldo)
                .HasColumnName(@"Saldo")
                .HasColumnType("decimal")
                .IsRequired();                
        }
    }
}
