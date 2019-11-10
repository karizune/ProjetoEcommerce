using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class ClienteConfiguration: EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente", "perfil");
            HasKey(x => x.IDCliente);

            Property(x => x.IDCliente)
                .HasColumnName(@"IDCliente")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.Senha)
                .HasColumnName(@"Senha")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName(@"Tipo")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.Foto)
                .HasColumnName(@"Foto")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
