using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BlackjackBot.Data.Repositories.Implemenations
{
    public class UsersRepository : Repository<User>, IUsersRepository, IRepository<User>
    {
        public UsersRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<User> GetByIdAsync(long id)
        {
            return await _context.Users
                .Include(u => u.ActiveSession)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
