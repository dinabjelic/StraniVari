using AutoMapper;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Base
{
    public class BaseCrudService<T, TInsertUpdate, TGet> : ICrudService<T, TInsertUpdate, TGet> where TInsertUpdate : class where T : class where TGet: class
    {
        private readonly StraniVariDbContext _dbContext;
        protected readonly IMapper _mapper;

        public BaseCrudService(StraniVariDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public T Delete(int id)
        {
            var set = _dbContext.Set<T>();
            var entity = set.Find(id);

            if (entity == null)
            {
                throw new ArgumentException($"Entity with id {id} not found.");
            }

            set.Remove(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public async Task<List<TGet>> GetAll()
        {
            var entity = _dbContext.Set<T>();
            var list = entity.ToList();
            return _mapper.Map<List<TGet>>(list);
        }

        public async Task<TGet> GetById(int id)
        {
            var set = _dbContext.Set<T>();
            var entity = set.Find(id);
            if (entity == null)
            {
                throw new ArgumentException("Invalid request");
            }
            return _mapper.Map<TGet>(entity);
        }

        public T Insert(TInsertUpdate request)
        {
            var set = _dbContext.Set<T>();
            T entity = _mapper.Map<T>(request);

            set.Add(entity);
           _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public T Update(int id, TInsertUpdate request)
        {
            if (request == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var set = _dbContext.Set<T>();
            var entity = set.Find(id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _mapper.Map(request, entity);

            _dbContext.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }
}
