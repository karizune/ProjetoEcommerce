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
            HasKey(x => x.GrupoDeAcessoID);

            Property(x => x.GrupoDeAcessoID)
                .HasColumnName(@"GrupoDeAcessoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descricao)
                .HasColumnName(@"Descricao")
                .HasColumnType("varchar")
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

        }
    }
}
