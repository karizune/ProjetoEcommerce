using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class GrupoUsuarioConfiguration : EntityTypeConfiguration<GrupoUsuario>
    {
        public GrupoUsuarioConfiguration()
        {
            ToTable("seguranca.Grupo_Usuario");
            HasKey(x => x.GrupoID);
            HasKey(x => x.UsuarioID);

            Property(x => x.GrupoID).HasColumnName(@"GrupoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UsuarioID).HasColumnName(@"UsuarioID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
