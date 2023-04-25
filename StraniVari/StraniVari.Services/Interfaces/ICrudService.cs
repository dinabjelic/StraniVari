namespace StraniVari.Services.Interfaces
{
    public interface ICrudService <T, TInsertUpdate> : IReadService<T> where TInsertUpdate :class where T : class
    {
        Task Insert(TInsertUpdate request);
        Task Update(int id, TInsertUpdate request);
        Task Delete(int id);
    }
}
