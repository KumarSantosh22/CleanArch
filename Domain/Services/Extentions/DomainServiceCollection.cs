using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts.Tickets;
using UseCases.Providers;

namespace UseCases.Extentions
{
    public static class DomainServiceCollection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IRaiseTicketRequest, RaiseTicketRequest>();
        }
    }
}
