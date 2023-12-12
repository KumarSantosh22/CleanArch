using Entities;
using UseCases.Contracts.Tickets;

namespace UseCases.Providers
{
    public class RaiseTicketRequest : IRaiseTicketRequest
    {
        public async Task<Ticket> CreateTicketRequest(string name)
        {
            return new Ticket()
            {
                Id=Guid.NewGuid(),
                Name= name,
                CreatedOn=DateTime.Now,
                CreatedBy=0,
                UpdateOn=DateTime.Now,
                UpdateBy=0,
            };
        }
    }
}
