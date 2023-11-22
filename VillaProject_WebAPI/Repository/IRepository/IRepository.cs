using System.Linq.Expressions;
using VillaProject_WebAPI.Models;

namespace VillaProject_WebAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);
        Task CreateAsync(T villa);
        Task RemoveAsync(T villa);
        Task SaveAsync();
    }
}
