﻿using ProjetoEcommerce.Dominio.Entidades.Entrega;
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
        public BairroConfiguration(){

            ToTable("Bairro");
            HasKey(x => x.BairroID);

            Property(x => x.BairroID)
                .HasColumnName(@"BairroID")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}