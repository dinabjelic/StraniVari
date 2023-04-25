using Microsoft.EntityFrameworkCore;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class BaseReadService<T> : IReadService<T> where T : class
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly DbSet<T> _dbSet;


        public BaseReadService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
            _dbSet = _straniVariDbContext.Set<T>();

        }
        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
