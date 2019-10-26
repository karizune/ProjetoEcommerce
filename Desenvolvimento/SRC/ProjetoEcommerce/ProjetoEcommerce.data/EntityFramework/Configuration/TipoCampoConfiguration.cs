using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.data.EntityFramework.Configuration
{
    class TipoCampoConfiguration : EntityTypeConfiguration<TipoCampo>
    {
        public TipoCampoConfiguration()
        {
            ToTable("TipoCampo");
            HasKey(x => x.TipoCampoID);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"DescricaoID")
                    .HasColumnType("varchar")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"UsuarioID")
                    .HasColumnType("varchar")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"StatusID")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"CriadoEm")
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.TipoCampoID)
                    .HasColumnName(@"AtualizadoEm")
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


        }

    }
}
