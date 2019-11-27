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
           
            ToTable("Carrinho", "Grupo2");
            
            HasKey(x => x.CarrinhoID);

            Property(x => x.CarrinhoID).HasColumnName(@"CarrinhoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.UsuarioID).HasColumnName(@"UsuarioID")
                .HasColumnType("int");

            Property(x => x.EnderecoID).HasColumnName(@"EnderecoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.PrecoTotal).HasColumnName(@"PrecoTotal")
                .HasColumnType("decimal")
                .IsRequired();

            Property(x => x.PrecoFrete).HasColumnName("PrecoFrete")
                .HasColumnType("decimal")
                .IsRequired();

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
