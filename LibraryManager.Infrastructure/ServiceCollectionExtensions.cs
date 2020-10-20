using LibraryManager.Domain.Repositories;
using LibraryManager.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthorRepository, AuthorRepository>();

            return services;
        }
    }
}
