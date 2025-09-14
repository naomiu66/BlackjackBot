using BlackjackBot.Data.Models;

namespace BlackjackBot.Data.Repositories.Abstractions
{
    public interface ISessionsRepository
    {
        public Task<Session> GetByIdAsync(Guid id);
        public Task<List<Session>> GetByChatIdAsync(long chatId);
    }
}
