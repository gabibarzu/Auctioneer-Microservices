using AccountApi.Services;
using AccountApi.Services.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace AccountApi.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDependencies(this IServiceCollection services)
        {
            services.InjectServices();
            return services;
        }

        private static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
