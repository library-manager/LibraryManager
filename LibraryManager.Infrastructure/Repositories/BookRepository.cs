using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Entities.Dtos;
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

        public IList<GetAllBooksDto> GetAll()
        {
            return Query().Include(b => b.Author).Select(b => new GetAllBooksDto
            {
                Name = b.Name,
                AuthorName = b.Author.Name,
                ImageUrl = b.ImageUrl,
                Summary = b.Summary
            }).ToList();
        }

        public Book GetAuthorById(int id)
        {
            return Query().Include(b => b.Author).FirstOrDefault(x => x.Id == id);
        }
    }
}
