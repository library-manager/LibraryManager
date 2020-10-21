using LibraryManager.Domain.Entities;
using LibraryManager.Infrastructure.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure
{
    public class LibraryManagerContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryManagerContext(DbContextOptions<LibraryManagerContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
