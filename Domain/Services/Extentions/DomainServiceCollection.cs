using Microsoft.Extensions.DependencyInjection;
using Services.Contracts.Tickets;
using Services.Providers;

namespace Services.Extentions
{
    public static class DomainServiceCollection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IRaiseTicketRequest, RaiseTicketRequest>();
        }
    }
}
