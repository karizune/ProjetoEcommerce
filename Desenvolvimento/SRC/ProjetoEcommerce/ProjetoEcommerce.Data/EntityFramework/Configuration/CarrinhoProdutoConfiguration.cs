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
            ToTable("CarrinhoProduto", "Grupo2");
            //ToTable("CarrinhoProduto");
            HasKey(x => new { x.CarrinhoID, x.ProdutoID,x.UsuarioID });

            //.HasDatabaseGeneratedOption
            //(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(x => x.ProdutoID).HasColumnName(@"ProdutoID")
                .HasColumnType("int")
                .IsRequired();
            
            Property(x => x.ProdutoID).HasColumnName(@"UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CarrinhoID).HasColumnName(@"CarrinhoID")
                .HasColumnType("int")
                .IsRequired();


            Property(x => x.Quantidade).HasColumnName(@"Quantidade")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.PrecoTotal).HasColumnName(@"PrecoTotal")
                .HasColumnType("decimal")
                .IsRequired();


            //Property(x => x.PrecoUnitario).HasColumnName(@"PrecoUnitario")
            //    .HasColumnType("decimal")
            //    .IsRequired()
            //    .HasDatabaseGeneratedOption
            //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);


            //LOG

            Property(x => x.Status).HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();


            Property(x => x.Usuario).HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm")
                .HasColumnType("DateTime")
                .IsRequired();


            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm")
                .HasColumnType("DateTime")
                .IsRequired();
                
        }

    }
}
