using BlackjackBot.Data.Repositories.Abstractions;

namespace BlackjackBot.Services.Abstractions
{
    public abstract class Service<T> where T : class
    {
        protected readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public virtual async Task<bool> RemoveAsync(T entity)
        {
            return await _repository.RemoveAsync(entity);
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
