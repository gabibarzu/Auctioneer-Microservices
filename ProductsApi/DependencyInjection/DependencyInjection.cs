using Microsoft.Extensions.DependencyInjection;

using ProductsApi.Services;
using ProductsApi.Services.Interfaces;

namespace ProductsApi.DependencyInjection
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
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IDealsService, DealsService>();
            services.AddTransient<IBidService, BidService>();
        }
    }
}
