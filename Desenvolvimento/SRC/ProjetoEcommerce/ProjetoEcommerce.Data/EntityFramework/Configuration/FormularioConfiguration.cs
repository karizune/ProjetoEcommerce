using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class FormularioConfiguration : EntityTypeConfiguration<Formulario>
    {
        public FormularioConfiguration()
        {
            ToTable("seguranca.Formulario");
            HasKey(x => x.FormularioID);

            Property(x => x.FormularioID).HasColumnName(@"FormularioID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(100)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.URL).HasColumnName(@"URL").HasColumnType("varchar()").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}
