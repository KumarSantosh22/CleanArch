using Services;

namespace API.Extentions
{
    public static class CoreServiceCollection
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAppServices(configuration);
        }
    }
}
