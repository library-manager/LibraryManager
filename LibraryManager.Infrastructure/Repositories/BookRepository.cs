using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Services.Contracts;
using LibraryManager.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryManagerContext context)
            : base(context)
        {
        }

        public IList<Book> GetAll()
        {
            return Query().ToList();
        }

        public Book GetAuthorById(int id)
        {
            return Query().Include(b => b.Author).FirstOrDefault(x => x.Id == id);
        }
    }
}
