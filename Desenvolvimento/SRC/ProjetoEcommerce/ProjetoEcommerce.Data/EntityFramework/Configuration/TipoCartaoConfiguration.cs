﻿using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class TipoCartaoConfiguration : EntityTypeConfiguration<TipoCartao>
    {
        public TipoCartaoConfiguration()
        {
            ToTable("pagamento.TipoCartao");
            HasKey(x => x.TipoCartaoID);

            Property(x => x.TipoCartaoID).HasColumnName(@"TipoCartaoID").HasColumnType("int").IsRequired();
            Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(50)").IsRequired();

            Property(x => x.AtualizadoEm)
             .HasColumnName(@"AtualizadoEm")
             .HasColumnType("datetime")
             .IsRequired();

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName(@"Status")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
