namespace StraniVari.Services.Interfaces
{
    public interface ICrudService <T, TInsert, TUpdate, TGet> : IReadService<T,TGet> where TInsert :class where T : class where TGet: class
    {
        Task Insert(TInsert request);
        Task Update(int id, TUpdate request);
        Task Delete(int id);
    }
}
