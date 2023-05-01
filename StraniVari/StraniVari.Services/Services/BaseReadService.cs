using AutoMapper;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class BaseReadService<T, TGet> : IReadService<T, TGet> where T : class where TGet: class
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IMapper _mapper;


        public BaseReadService(StraniVariDbContext straniVariDbContext, IMapper mapper)
        {
            _straniVariDbContext = straniVariDbContext;
            _mapper = mapper;

        }

        public async Task<List<TGet>> GetAll()
        {
            var entity = _straniVariDbContext.Set<T>();
            var list = entity.ToList();
            return _mapper.Map<List<TGet>>(list);
        }

        public async Task<TGet> GetById(int id)
        {
            var set = _straniVariDbContext.Set<T>();
            var entity = set.Find(id);
            if (entity == null)
            {
                throw new ArgumentException("Invalid request");
            }
            return _mapper.Map<TGet>(entity);
        }
    }
}
