using Entities;

namespace Services.Contracts.Tickets
{
    public interface IRaiseTicketRequest
    {
        Task<Ticket> CreateTicketRequest();
    }
}
