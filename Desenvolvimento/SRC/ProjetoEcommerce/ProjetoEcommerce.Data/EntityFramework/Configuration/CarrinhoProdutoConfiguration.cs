using ProjetoEcommerce.Dominio.Entidades.Carrinho;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    public class CarrinhoProdutoConfiguration: EntityTypeConfiguration<CarrinhoProduto>
    {
        public CarrinhoProdutoConfiguration()
        {
            ToTable("CarrinhoProduto", "carrinho");
            HasKey(x => new { x.CarrinhoProdutoID, x.ProdutoID });

            Property(x => x.CarrinhoProdutoID).HasColumnName(@"CarrinhoProdutoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.Quantidade).HasColumnName(@"Quantidade")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            //Property(x => x.PrecoUnitario).HasColumnName(@"PrecoUnitario")
            //    .HasColumnType("decimal")
            //    .IsRequired()
            //    .HasDatabaseGeneratedOption
            //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);


            //LOG

            Property(x => x.Status).HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.Usuario).HasColumnName(@"Usuario")
                .HasColumnType("string")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm")
                .HasColumnType("DateTime")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm")
                .HasColumnType("DateTime")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }

    }
}
