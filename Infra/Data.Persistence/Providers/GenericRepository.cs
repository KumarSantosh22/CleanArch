using Data.Persistence.DbContexts;

namespace Data.Persistence.Providers
{
    public class GenericRepository<T> : BaseRepository<T> where T : class
    {
        public GenericRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
