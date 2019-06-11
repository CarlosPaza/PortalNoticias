using PortalNoticias.WebApi.Model;
using System.Threading.Tasks;

namespace PortalNoticias.WebApi.Repository
{
    public interface IPortalNoticiasRepository
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<IModelo[]> GetByQtd(int qtd);
        Task<IModelo> GetById(int Id);
        Task<IModelo[]> GetByText(string text);
    }
}
