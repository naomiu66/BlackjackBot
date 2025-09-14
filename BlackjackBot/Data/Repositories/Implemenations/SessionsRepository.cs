using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BlackjackBot.Data.Repositories.Implemenations
{
    public class SessionsRepository : Repository<Session>, ISessionsRepository, IRepository<Session>
    {
        public SessionsRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<List<Session>> GetByChatIdAsync(long chatId)
        {
            return await _context.Sessions
                .Where(s => s.chatId == chatId)
                .ToListAsync();
        }

        public async Task<Session> GetByIdAsync(Guid id)
        {
            return await _context.Sessions
                .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
