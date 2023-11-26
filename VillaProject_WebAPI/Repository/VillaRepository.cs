using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VillaProject_WebAPI.Data;
using VillaProject_WebAPI.Models;
using VillaProject_WebAPI.Repository.IRepository;

namespace VillaProject_WebAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber villaNumber)
        {
            villaNumber.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(villaNumber);
            await _db.SaveChangesAsync();
            return villaNumber;
        }
    }
}
