using Data.Entities;
using Data.Persistence.Providers;

namespace Data.Persistence.Contracts
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        GenericRepository<Ticket> Ticket
        {
            get;
        }
    }
}
