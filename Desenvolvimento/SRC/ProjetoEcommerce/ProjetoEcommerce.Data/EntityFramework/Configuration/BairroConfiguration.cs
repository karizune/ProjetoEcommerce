using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration 
{
    class BairroConfiguration : EntityTypeConfiguration<Bairro>
    {
        public BairroConfiguration()
        {

            ToTable("Entrega.Bairro");
            HasKey(x => x.BairroID);

            Property(x => x.BairroID)
                .HasColumnName(@"BairroID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CidadeID)
                .HasColumnName(@"CidadeID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("Date")
                .IsRequired();

            Property(x => x.AtualizaEm)
                .HasColumnName(@"AtualizaEm")
                .HasColumnType("Date")
                .IsRequired();



        }
    }
}
