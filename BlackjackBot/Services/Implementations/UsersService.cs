using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;
using BlackjackBot.Services.Abstractions;

namespace BlackjackBot.Services.Implementations
{
    public class UsersService : Service<User>, IUsersService
    {
        public UsersService(IRepository<User> repository) : base(repository)
        {
        }
    }
}
