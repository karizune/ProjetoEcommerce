using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
     class RuaConfiguration : EntityTypeConfiguration<Rua>
    {
        public RuaConfiguration()
        {
            ToTable("Rua");
            HasKey(x => x.RuaID);

            Property(x => x.RuaID)
                .HasColumnName(@"RuaID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

          
        }

    }
}
