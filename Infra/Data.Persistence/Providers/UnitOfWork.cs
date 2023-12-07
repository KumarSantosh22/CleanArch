using Data.Entities;
using Data.Persistence.Contracts;
using Data.Persistence.DbContexts;

namespace Data.Persistence.Providers
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ticket = new Lazy<GenericRepository<Ticket>>(() => new GenericRepository<Ticket>(_context));
            appuser = new Lazy<GenericRepository<Appuser>>(() => new GenericRepository<Appuser>(_context));
        }

        public GenericRepository<Appuser> Appuser => appuser.Value;
        public GenericRepository<Ticket> Ticket => ticket.Value;

        Lazy<GenericRepository<Appuser>> appuser;
        Lazy<GenericRepository<Ticket>> ticket;

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
