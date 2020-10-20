using LibraryManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure
{
    public class LibraryManagerContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public LibraryManagerContext(DbContextOptions<LibraryManagerContext> options) :
            base(options)
        {
        }
    }
}
