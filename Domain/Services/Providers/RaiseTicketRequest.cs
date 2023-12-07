using Entities;
using Services.Contracts.Tickets;

namespace Services.Providers
{
    public class RaiseTicketRequest : IRaiseTicketRequest
    {
        public async Task<Ticket> CreateTicketRequest()
        {
            return new Ticket()
            {
                Id=Guid.NewGuid(),
                Name="Test Service",
                CreatedOn=DateTime.Now,
                CreatedBy=0,
                UpdateOn=DateTime.Now,
                UpdateBy=0,
            };
        }
    }
}
