using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.data.EntityFramework.Configuration
{
    class RegistroConfiguration : EntityTypeConfiguration<Registro>
    {
        public RegistroConfiguration()
        {
            ToTable("Relatorio.Registro");
            HasKey(x => x.RelatorioID);
            HasKey(x => x.UsuarioID);

            Property(x => x.RelatorioID)
                .HasColumnName(@"RelatorioID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.UsuarioID)
                .HasColumnName(@"UsuarioID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            Property(x => x.Descricao)
                .HasColumnName(@"Descricao")
                .HasColumnType("varchar(100)")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar(50)")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.AtualizadoEm)
                .HasColumnName(@"AtualizdoEm")
                .HasColumnType("datetime")
                .IsRequired();
        }


    }
}
