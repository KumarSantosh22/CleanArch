using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PaymentGateways.Concerns;
using Stripe;
using PaymentGateways.Contracts;
using PaymentGateways.Providers;

namespace PaymentGateways.Extentions
{
    public static class PgServiceCollection
    {
        public static void AddPaymentGateways(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton((StripeConfig)configuration.GetSection("Stripe"));
            StripeConfiguration.ApiKey = configuration["Stripe:SecretKey"];
            services.AddScoped<IStripeGateway, StripeGatewayProvider>();
        }
    }
}
