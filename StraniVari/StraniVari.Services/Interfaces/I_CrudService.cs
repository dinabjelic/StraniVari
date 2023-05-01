namespace StraniVari.Services.Interfaces
{
    public interface I_CrudService<T, TInsert, TUpdate,TGet> : IReadService<T, TGet> where TInsert : class where TUpdate : class where T : class where TGet : class
    {
        Task Insert(TInsert request);
        Task Update(int id,TUpdate request);
        Task Delete(int id);
    }
}
