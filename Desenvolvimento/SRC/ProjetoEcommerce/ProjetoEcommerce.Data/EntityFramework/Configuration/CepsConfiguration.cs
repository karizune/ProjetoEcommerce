using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class CepsConfiguration : EntityTypeConfiguration<Ceps>
    {
        public CepsConfiguration()
        {

            ToTable("Ceps");
            HasKey(x => x.CEP);

            Property(x => x.CEP)
                .HasColumnName(@"CEP")
                .HasColumnType("char")
                .HasMaxLength(8)
                .IsRequired();

            Property(x => x.EstadoID)
                .HasColumnName(@"EstadoID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CidadeID)
                .HasColumnName(@"CidadeID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.BairroID)
                .HasColumnName(@"BairroID")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.RuaID)
                .HasColumnName(@"RuaID")
                .HasColumnType("int")
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
