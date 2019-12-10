﻿using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class StatusPagamentoConfiguration : EntityTypeConfiguration<StatusPagamento>
    {
        public StatusPagamentoConfiguration()
        {
            ToTable("StatusPagamento", "pagamento");
            HasKey(x => x.StatusPagamentoID);
            Property(x => x.StatusPagamentoID)
                .HasColumnName(@"StatusPagametnoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .HasColumnName(@"Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

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
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}