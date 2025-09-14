using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;
using BlackjackBot.Services.Abstractions;

namespace BlackjackBot.Services.Implementations
{
    public class SessionsService : Service<Session>, ISessionsService
    {
        public SessionsService(IRepository<Session> repository) : base(repository)
        {
        }
    }
}
