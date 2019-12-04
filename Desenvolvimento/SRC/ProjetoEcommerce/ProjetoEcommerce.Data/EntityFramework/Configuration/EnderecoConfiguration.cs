using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfiguration()
        {
            ToTable("Endereco", "Grupo2");

            HasKey(x => x.EnderecoID);

            Property(x => x.EnderecoID).HasColumnName(@"EnderecoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Descricao).HasColumnName(@"Descricao")
                .HasColumnType("varchar");
        }

    }
}
