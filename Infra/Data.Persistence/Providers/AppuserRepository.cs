using Data.Entities;
using Data.Persistence.Contracts;
using Data.Persistence.DbContexts;

namespace Data.Persistence.Providers
{
    public class AppuserRepository : BaseRepository<Appuser>, IAppuserRepository
    {
        public AppuserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
