using BlazorCleanArchitecture.Domain.Interfaces;
using BlazorCleanArchitecture.Infrastructure.Data;
using BlazorCleanArchitecture.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCleanArchitecture.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions // Add static class wrapper
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration config)
        {
            // Register DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("BlazorCleanArchitecture")));

            // Register repositories
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}