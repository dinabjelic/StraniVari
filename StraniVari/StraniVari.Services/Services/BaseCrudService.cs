using AutoMapper;
using StraniVari.Database;
using StraniVari.Services.Services;

namespace StraniVari.Services.Base
{
    public class BaseCrudService<T, TInsert, TUpdate, TGet> : BaseReadService<T, TGet> where TInsert : class where T : class where TGet: class
    {
        private readonly StraniVariDbContext _dbContext;
        protected readonly IMapper _mapper;

        public BaseCrudService(StraniVariDbContext dbContext, IMapper mapper):base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public virtual async Task Delete(int id)
        {
            var set = _dbContext.Set<T>();
            var entity = set.Find(id);

            if (entity == null)
            {
                throw new ArgumentException($"Entity with id {id} not found.");
            }

            set.Remove(entity);
            await _dbContext.SaveChangesAsync();

        }

        public virtual async Task Insert(TInsert request)
        {
            var set = _dbContext.Set<T>();
            T entity = _mapper.Map<T>(request);

            await set.AddAsync(entity);
           await _dbContext.SaveChangesAsync();
        }

        public virtual async Task Update(int id, TUpdate request)
        {
            if (request == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var set = _dbContext.Set<T>();
            var entity =await set.FindAsync(id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _mapper.Map(request, entity);

            await _dbContext.SaveChangesAsync();
        }
    }
}
