using System.Linq.Expressions;
using VillaProject_WebAPI.Models;

namespace VillaProject_WebAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa villa);
    }
}
