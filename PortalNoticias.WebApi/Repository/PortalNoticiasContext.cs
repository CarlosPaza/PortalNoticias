using Microsoft.EntityFrameworkCore;
using PortalNoticias.WebApi.Model;
using PortalNoticias.WebApi.Repository.Configuration;

namespace PortalNoticias.WebApi.Repository
{
    public class PortalNoticiasContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Noticia> Noticias { get; set; }

        public PortalNoticiasContext(DbContextOptions<PortalNoticiasContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new NoticiaConfiguration());
        }
    }
}
