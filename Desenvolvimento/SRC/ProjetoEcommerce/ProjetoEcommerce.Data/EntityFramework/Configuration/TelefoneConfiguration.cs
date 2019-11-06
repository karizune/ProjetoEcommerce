using ProjetoEcommerce.Dominio.Entidades.Perfil;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class TelefoneConfiguration : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfiguration()
        {
            ToTable("Telefone","perfil");
            HasKey(x => new { x.IDTelefone, x.IDCliente });

            Property(x => x.IDTelefone)
               .HasColumnName(@"IDTelefone")
               .HasColumnType("int")
               .IsRequired()
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}
