namespace StraniVari.Services.Interfaces
{
    public interface IReadService<T> where T : class
    {
        public Task<List<T>> GetAll();
        public Task<T> GetById(int id);
    }
}
