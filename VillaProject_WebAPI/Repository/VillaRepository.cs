using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VillaProject_WebAPI.Data;
using VillaProject_WebAPI.Models;
using VillaProject_WebAPI.Repository.IRepository;

namespace VillaProject_WebAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa villa)
        {
            villa.UpdatedDate = DateTime.Now;
            _db.Villas.Update(villa);
            await _db.SaveChangesAsync();
            return villa;
        }
    }
}
