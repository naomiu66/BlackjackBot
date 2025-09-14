namespace BlackjackBot.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> RemoveAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}
