using BlackjackBot.Data.Models;
using BlackjackBot.Data.Repositories.Abstractions;
using BlackjackBot.Services.Abstractions;

namespace BlackjackBot.Services.Implementations
{
    public class HandsService : Service<Hand>, IHandsService
    {
        public HandsService(IRepository<Hand> repository) : base(repository)
        {
        }
    }
}
