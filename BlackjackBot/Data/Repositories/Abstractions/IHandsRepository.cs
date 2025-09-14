using BlackjackBot.Data.Models;

namespace BlackjackBot.Data.Repositories.Abstractions
{
    public interface IHandsRepository
    {
        public Task<Hand> GetByIdAsync(Guid id);
        public Task<List<Hand>> GetHandsBySessionIdAsync(Guid sessionId);
        public Task<List<Hand>> GetHandsByUserIdAsync(long userId); 
    }
}
