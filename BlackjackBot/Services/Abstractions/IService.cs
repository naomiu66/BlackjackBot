namespace BlackjackBot.Services.Abstractions
{
    public interface IService<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> RemoveAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}
