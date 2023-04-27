namespace StraniVari.Services.Interfaces
{
    public interface IReadService<TGet> where TGet : class
    {
        Task<List<TGet>> GetAll();
        Task<TGet> GetById(int id);
    }
}
