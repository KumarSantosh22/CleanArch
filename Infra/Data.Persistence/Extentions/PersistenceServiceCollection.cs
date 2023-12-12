using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Data.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Data.Persistence.Contracts;
using Data.Persistence.Providers.Repositories;
using Data.Persistence.Providers;

namespace Data.Persistence.Extentions
{
    public static class PersistenceServiceCollection
    {
        public static void AddInfraPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddDbContext<AppDbContext>(options =>
            {
                _ = options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                    , c =>
                {
                    c.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });
            });

            #region Repository
            _ = services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));
            _ = services.AddTransient<IUnitOfWork, UnitOfWork>();

            _ = services.AddTransient<ITicketRepository, TicketRepository>();
            _ = services.AddTransient<IAppuserRepository, AppuserRepository>();
            #endregion
        }
    }
}
