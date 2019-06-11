using Microsoft.EntityFrameworkCore;
using PortalNoticias.WebApi.Model;
using System.Linq;
using System.Threading.Tasks;

namespace PortalNoticias.WebApi.Repository
{
    public class AutorRepository : IPortalNoticiasRepository
    {
        private readonly PortalNoticiasContext _context;

        public AutorRepository(PortalNoticiasContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IModelo[]> GetByQtd(int qtd)
        {
            IQueryable<Autor> query = _context.Autores.OrderBy(a => a.Id);
            return await query.ToArrayAsync();
        }

        public async Task<IModelo> GetById(int Id)
        {
            IQueryable<Autor> query = _context.Autores;
            query = query.Where(a => a.Id == Id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<IModelo[]> GetByText(string text)
        {
            IQueryable<Autor> query = _context.Autores;

            query = query.OrderBy(a => a.Id)
                .Where(a => a.Nome.Contains(text));

            return await query.ToArrayAsync();
        }
    }
}
