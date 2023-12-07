using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
