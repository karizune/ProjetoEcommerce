using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produto", "Grupo2");
            HasKey(x => x.ProdutoID);

            Ignore(x => x.Qtde);

            Property(x => x.ProdutoID).HasColumnName(@"ProdutoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Nome).HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.Preco).HasColumnName(@"Preco")
                .HasColumnType("decimal")
                .IsRequired();

            Property(x => x.Imagem).HasColumnName(@"Imagem")
               .HasColumnType("varchar");
        }
    }
}
