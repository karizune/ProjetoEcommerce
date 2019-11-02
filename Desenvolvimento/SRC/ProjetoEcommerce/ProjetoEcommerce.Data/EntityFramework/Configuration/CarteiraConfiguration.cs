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
            ToTable("Carteira", "pagamento");
            HasKey(x => x.CarteiraID);

            Property(x => x.CarteiraID)
                .HasColumnName(@"CarteiraID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Saldo)
                .HasColumnName(@"Saldo")
                .HasColumnType("decimal")
                .IsRequired();

            Property(x => x.UsuarioID)
                .HasColumnName(@"UsuarioID")
                .HasColumnType("int")
                .IsRequired();

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
