using ProjetoEcommerce.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Configuration
{
    public class LojaConfiguration:EntityTypeConfiguration<Loja>
    {
        public LojaConfiguration()
        {
            //LojaID
            ToTable("Loja");
            HasKey(x => x.LojaID);
            Property(x => x.LojaID).HasColumnName(@"LojaID").HasColumnType("int").IsRequired().
            HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            //Nome
            ToTable("Loja");
            HasKey(x => x.Nome);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar").IsRequired();
        

            //Status
            ToTable("Loja");
            HasKey(x => x.Status);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            //Usuario
            ToTable("Loja");
            HasKey(x => x.Usuario);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired();
            //CriadoEm
            ToTable("Loja");
            HasKey(x => x.CriadoEm);
            Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            //AtualizadoEm
            ToTable("Loja");
            HasKey(x => x.AtualizadoEm);
            Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();

        }
    }
}
