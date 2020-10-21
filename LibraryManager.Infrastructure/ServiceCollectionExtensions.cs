using LibraryManager.Domain.Repositories;
using LibraryManager.Domain.Services.Contracts;
using LibraryManager.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();

            return services;
        }
    }
}
