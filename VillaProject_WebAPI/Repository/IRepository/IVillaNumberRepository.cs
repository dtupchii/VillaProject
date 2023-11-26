using System.Linq.Expressions;
using VillaProject_WebAPI.Models;

namespace VillaProject_WebAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber villaNumber);
    }
}
