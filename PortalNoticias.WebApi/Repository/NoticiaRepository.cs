using Microsoft.EntityFrameworkCore;
using PortalNoticias.WebApi.Model;
using System.Linq;
using System.Threading.Tasks;

namespace PortalNoticias.WebApi.Repository
{
    public class NoticiaRepository : IPortalNoticiasRepository
    {
        private readonly PortalNoticiasContext _context;

        public NoticiaRepository(PortalNoticiasContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            Noticia noticia = entity as Noticia;
            Autor autor = _context.Autores.Where(a => a.Id == noticia.Autor.Id).FirstOrDefault();
            if (autor == null)
                autor = new Autor(noticia.Autor.Nome);
            noticia.Autor = autor;
            _context.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IModelo[]> GetByQtd(int qtd)
        {
            IQueryable<Noticia> query = _context.Noticias.Include(a => a.Autor);
            query = query.OrderByDescending(a => a.Id).Take(qtd);
            return await query.ToArrayAsync();
        }

        public async Task<IModelo> GetById(int Id)
        {
            IQueryable<Noticia> query = _context.Noticias.Include(a => a.Autor);
            query = query.Where(a => a.Id == Id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<IModelo[]> GetByText(string text)
        {
            IQueryable<Noticia> query = _context.Noticias.Include(a => a.Autor);

            query = query.OrderByDescending(a => a.Id)
                .Where(a => a.Texto.Contains(text) || a.Titulo.Contains(text) || a.Autor.Nome.Contains(text));


            return await query.ToArrayAsync();
        }

    }
}
