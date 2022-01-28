using SampleClearArchictecture.Application.Services;
using SampleClearArchictecture.Core.Interfaces.Repositories;
using SampleClearArchictecture.Infrastructure.Repositories;

namespace SampleClearArchitecture.API.Extensions
{
    public static class ServicesCollectionsExtensions
    {

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
           // builder.Services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
