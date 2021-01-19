using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Shared.Extensions.Consul
{
    public static class StartupConfig
    {
        public static ConfigurationSetting RegisterConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConfigurationSetting>(configuration.GetSection("Configuration"));
            var serviceProvider = services.BuildServiceProvider();
            var iop = serviceProvider.GetService<IOptions<ConfigurationSetting>>();
            return iop.Value;
        }
    }
}
