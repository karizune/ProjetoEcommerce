﻿using ProjetoEcommerce.Dominio.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.EntityFramework.Configuration
{
    class GrupoUsuarioConfiguration : EntityTypeConfiguration<GrupoUsuario>
    {
        public GrupoUsuarioConfiguration()
        {
            ToTable("seguranca.Grupo_Usuario");
            HasKey(x => x.GrupoID);
            HasKey(x => x.UsuarioID);

            Property(x => x.GrupoID)
                .HasColumnName(@"GrupoID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UsuarioID)
                .HasColumnName(@"UsuarioID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Status)
               .HasColumnName(@"Status")
               .HasColumnType("int")
               .IsRequired();

            Property(x => x.Usuario)
                .HasColumnName(@"Usuario")
                .Hascolumntype("varchar")
                .IsRequired()
                .HasMaxLenglet(100);

            Property(x => x.CriadoEm)
                .HasColumnName(@"CriadoEm")
                .HasColumnType(@"datetime")
                .IsRequired();

            Property(x => x.AtualizadoEm)
                .HasColumnName(@"AtualizadoEm")
                .HasColumnType(@"datetime")
                .IsRequired();
        }
    }
}