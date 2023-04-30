namespace StraniVari.Services.Interfaces
{
    public interface ICrudService <T, TInsertUpdate, TGet> : IReadService<T,TGet> where TInsertUpdate :class where T : class where TGet: class
    {
        Task Insert(TInsertUpdate request);
        Task Update(int id, TInsertUpdate request);
        Task Delete(int id);
    }
}
