using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {

        public UsuarioConfiguration()
        {
            ToTable("Carrinho", "Grupo2");

            HasKey(x => x.UsuarioID);

            Property(x => x.UsuarioID).HasColumnName(@"UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Nome).HasColumnName(@"Nome")
                .HasColumnType("varchar(100)");
        }

    }
}
