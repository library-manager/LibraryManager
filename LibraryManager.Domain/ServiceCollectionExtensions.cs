using LibraryManager.Domain.Services.Contracts;
using LibraryManager.Domain.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();

            return services;
        }
    }
}
