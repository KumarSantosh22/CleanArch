using Data.Persistence.Extentions;
using PaymentGateways.Extentions;
using UseCases.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Contracts;
using Services.Providers;
using Services.Helpers;
using AutoMapper;

namespace Services
{
    public static class AppServiceCollection
    {
        public static void AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDomainServices();
            services.AddInfraPersistanceServices(configuration);
            services.AddPaymentGateways(configuration);

            // Auto Mapper Configurations
            MapperConfiguration mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<ITicketContract, TicketProvider>();
            services.AddScoped<IPaymentContract, PaymentProvider>();
        }
    }
}
