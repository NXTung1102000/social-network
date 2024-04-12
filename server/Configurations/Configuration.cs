
using Microsoft.Extensions.DependencyInjection;

namespace Configurations
{
    public static class Configuration
    {
        public static IServiceCollection AddConfigurations(this IServiceCollection services)
        {
            services.AddServices();
            // services.AddValidator();
            return services;
        }
    }
}
