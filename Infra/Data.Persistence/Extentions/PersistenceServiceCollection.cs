using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Data.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence.Extentions
{
    public static class PersistenceServiceCollection
    {
        public static void AddInfraPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddDbContext<AppDbContext>(options =>
            {
                _ = options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
