using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class CarrinhoConfiguration : EntityTypeConfiguration<Carrinho>
    {
        public CarrinhoConfiguration()
        {

            ToTable("Carrinho");
            HasKey(x => x.CarrinhoID);

            Property(x => x.CarrinhoID).HasColumnName("@CarinhoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.EnderecoID).HasColumnName("@EnderecoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.PrecoTotal).HasColumnName("@PrecoTotal")
                .HasColumnType("decimal")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.PrecoFrete).HasColumnName("@PrecoFrete")
                .HasColumnType("decimal")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            //LOG

            Property(x => x.Status).HasColumnName("@Status")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.Usuario).HasColumnName("@Usuario")
                .HasColumnType("sring")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.CriadoEm).HasColumnName("@CriadoEm")
                .HasColumnType("DateTime")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.AtualizadoEm).HasColumnName("@AtualizadoEm")
                .HasColumnType("DateTime")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }
}
