using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class FormularioGrupoConfiguration : EntityTypeConfiguration<FormularioGrupo>
    {
        public FormularioGrupoConfiguration()
        {
            ToTable("seguranca.FormularioGrupo");
            HasKey(x => x.FormularioID);
            HasKey(x => x.GrupoID);

            Property(x => x.FormularioID).HasColumnName(@"FormularioID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GrupoID).HasColumnName(@"GrupoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
