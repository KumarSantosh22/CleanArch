using Data.Entities;
using Data.Persistence.Contracts;
using Data.Persistence.DbContexts;

namespace Data.Persistence.Providers.Repositories
{
    public class TicketRepository: BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext dbContext) : base(dbContext)
        {
        }        
    }
}
