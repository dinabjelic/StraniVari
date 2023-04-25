using Microsoft.EntityFrameworkCore;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Base
{
    public class BaseCrudService<TEntity> : IBaseCrudService<TEntity> where TEntity : class
    {
        private readonly StraniVariDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseCrudService(StraniVariDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                throw new ArgumentException($"Entity with id {id} not found.");
            }
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
