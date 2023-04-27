namespace StraniVari.Services.Interfaces
{
    public interface ICrudService <T, TInsertUpdate, TGet> : IReadService<TGet> where TInsertUpdate :class where T : class where TGet: class
    {
        T Insert(TInsertUpdate request);
        T Update(int id, TInsertUpdate request);
        T Delete(int id);
    }
}
