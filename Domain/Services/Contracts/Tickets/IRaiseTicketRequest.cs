using Entities;

namespace UseCases.Contracts.Tickets
{
    public interface IRaiseTicketRequest
    {
        Task<Ticket> CreateTicketRequest(string Name);
    }
}
