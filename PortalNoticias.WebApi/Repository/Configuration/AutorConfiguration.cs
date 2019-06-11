using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalNoticias.WebApi.Model;

namespace PortalNoticias.WebApi.Repository.Configuration
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.Property(a => a.Id).HasColumnName("id_autor");

            builder.Property(a => a.Nome)
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
