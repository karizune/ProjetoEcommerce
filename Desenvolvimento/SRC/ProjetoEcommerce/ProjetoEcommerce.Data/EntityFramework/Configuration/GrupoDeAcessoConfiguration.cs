using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class GrupoDeAcessoConfiguration : EntityTypeConfiguration<GrupoDeAcesso>
    {
        public GrupoDeAcessoConfiguration()
        {
            ToTable("seguranca.GrupoDeAcesso");
            HasKey(x => x.GrupoID);

            Property(x => x.GrupoID).HasColumnName(@"GrupoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
