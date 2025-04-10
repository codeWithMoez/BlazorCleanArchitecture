using BlazorCleanArchitecture.Application.IServices;
using BlazorCleanArchitecture.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCleanArchitecture.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}