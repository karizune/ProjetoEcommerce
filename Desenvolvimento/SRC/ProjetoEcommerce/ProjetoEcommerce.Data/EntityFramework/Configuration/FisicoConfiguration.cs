using System;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class FisicoConfiguration : EntityTypeConfiguration<Fisico>
    {
        public FisicoConfiguration()
        {
            ToTable("Fisico", "perfil");
            HasKey(x => new { x.IDCliente });


            Property(x => x.CPF)
                .HasColumnName(@"CPF")
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();

            Property(x => x.DataNascimento)
               .HasColumnName(@"DataNascimento")
               .HasColumnType("datetime")
               .IsRequired();

            Property(x => x.IDSexo)
              .HasColumnName(@"IDSexo")
              .HasColumnType("int")
              .IsRequired();
        }
    }
}
