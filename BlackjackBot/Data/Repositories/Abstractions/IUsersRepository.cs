using BlackjackBot.Data.Models;

namespace BlackjackBot.Data.Repositories.Abstractions
{
    public interface IUsersRepository
    {
        public Task<User> GetByIdAsync(long id);
    }
}
