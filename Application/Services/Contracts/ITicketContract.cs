using DTOs.Request;
using DTOs.Response;

namespace Services.Contracts
{
    public interface ITicketContract
    {
        Task<bool> Create(CreateTicketDto dto);
        Task<TicketResponseDto> Get(string id);
        Task<IEnumerable<TicketResponseDto>> GetAll();
        Task<bool> Update();
        Task<TicketResponseDto> Delete(string id);
    }
}
