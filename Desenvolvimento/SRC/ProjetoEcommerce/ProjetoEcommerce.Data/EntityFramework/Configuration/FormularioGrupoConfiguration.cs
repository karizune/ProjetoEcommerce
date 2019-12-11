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
            ToTable("FormularioGrupo","seguranca");
            HasKey(x => new { x.FormularioID, x.GrupoID });

            Property(x => x.FormularioID)
                .HasColumnName(@"FormularioID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.GrupoID)
                .HasColumnName(@"GrupoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
                
            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType(@"datetime")
                .IsRequired();

            Property(x => x.AtualizadoEm)
                .HasColumnName(@"AtualizadoEm")
                .HasColumnType(@"datetime")
                .IsRequired();

            this.HasRequired(f => f.GrupoDeAcesso)
                .WithMany()
                .HasForeignKey(f => f.GrupoID);

        }
    }
}
