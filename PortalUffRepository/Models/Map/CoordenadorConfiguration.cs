﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalUffRepository.Models.Map
{
    public class CoordenadorConfiguration : IEntityTypeConfiguration<Coordenador>
    {
        public void Configure(EntityTypeBuilder<Coordenador> builder)
        {
            builder.ToTable("Coodenador");

            builder.HasKey(x => x.Id);

            builder.HasOne(f => f.Pessoa)
                   .WithMany(f => f.Coordenadores);

            builder.Property(x => x.Id)
                   .HasColumnName("Id")
                   .HasColumnType("int");

            builder.Property(x => x.CriadoPor)
                   .HasColumnName("CriadoPor")
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.CriadoEm)
                   .HasColumnName("CriadoEm")
                   .HasColumnType("datetime");

            builder.Property(x => x.ModifPor)
                   .HasColumnName("ModifPor")
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.ModifEm)
                   .HasColumnName("ModifEm")
                   .HasColumnType("datetime");

        }
    }
}
