using AutoMapper;
using Data.Persistence.Contracts;
using DTOs.Request;
using DTOs.Response;
using Entities;
using Enitity = Data.Entities;
using Services.Contracts;
using UseCases.Contracts.Tickets;

namespace Services.Providers
{
    public class TicketProvider : ITicketContract
    {
        private readonly IMapper mapper;
        private readonly IRaiseTicketRequest ticketRequest;
        private readonly ITicketRepository ticketRepository;

        public TicketProvider(IMapper mapper, IRaiseTicketRequest ticketRequest, ITicketRepository ticketRepository)
        {
            this.mapper = mapper;
            this.ticketRequest = ticketRequest;
            this.ticketRepository = ticketRepository;
        }

        public async Task<bool> Create(CreateTicketDto dto)
        {
            Ticket ticket = await ticketRequest.CreateTicketRequest(dto.Name);
            // Save to Db
            Enitity.Ticket t = mapper.Map<Enitity.Ticket>(source: ticket);
            await ticketRepository.AddAsync(t);
            await ticketRepository.SaveAsync();
            return true;
        }

        public Task<TicketResponseDto> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketResponseDto>> GetAll()
        {
            IEnumerable<Enitity.Ticket> t = ticketRepository.GetAll();
            IEnumerable<TicketResponseDto> tRes = mapper.Map<IEnumerable<TicketResponseDto>>(source: t);
            return (Task<IEnumerable<TicketResponseDto>>)tRes;
        }

        public Task<bool> Update()
        {
            throw new NotImplementedException();
        }

        public Task<TicketResponseDto> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
