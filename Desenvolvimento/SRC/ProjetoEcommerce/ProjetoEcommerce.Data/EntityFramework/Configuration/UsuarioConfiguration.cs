using System.Data.Entity.ModelConfiguration;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;


namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario");
            HasKey(x => x.IdUsuario);
            Property(x => x.IdUsuario)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
