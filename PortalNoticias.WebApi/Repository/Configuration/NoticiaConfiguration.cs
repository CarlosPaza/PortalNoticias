using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalNoticias.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalNoticias.WebApi.Repository.Configuration
{
    public class NoticiaConfiguration : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.Property(a => a.Id).HasColumnName("id_noticia");

            builder.Property(a => a.Titulo)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(a => a.Texto)
                .HasColumnType("text")
                .IsRequired();

            builder.Property<int>("id_autor")
                .IsRequired();

            builder.HasOne(a => a.Autor)
                .WithMany(b => b.Noticias)
                .HasForeignKey("id_autor")
                .HasConstraintName("FK_Autores");
        }
    }
}
