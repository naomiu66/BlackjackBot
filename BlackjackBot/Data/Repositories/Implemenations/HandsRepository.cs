using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;

namespace BlackjackBot.Data.Repositories.Implemenations
{
    public class HandsRepository : Repository<Hand>, IHandsRepository, IRepository<Hand>
    {
        public HandsRepository(ApplicationContext context) : base(context)
        {
        }

        public Task<Hand> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hand>> GetHandsBySessionIdAsync(Guid sessionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hand>> GetHandsByUserIdAsync(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
