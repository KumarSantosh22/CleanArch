using AutoMapper;
using Entity = Data.Entities;
using Domain = Entities;
using DTOs.Response;

namespace Services.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Entity.Ticket, Domain.Ticket>().ReverseMap();
            CreateMap<Entity.Ticket, TicketResponseDto>().ReverseMap();
        }
    }
}
