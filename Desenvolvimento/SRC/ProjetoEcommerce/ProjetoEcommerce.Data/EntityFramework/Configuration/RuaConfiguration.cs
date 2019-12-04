﻿using ProjetoEcommerce.Dominio.Entidades.Entrega;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    internal class RuaConfiguration : EntityTypeConfiguration<Rua>
    {
        public RuaConfiguration()
        {
            ToTable("Entrega.Rua");
            HasKey(x => x.RuaID);
           
            Property(x => x.RuaID)
                .HasColumnName(@"RuaID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.Status)
              .HasColumnName(@"Status")
              .HasColumnType("int")
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