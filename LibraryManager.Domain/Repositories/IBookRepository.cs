using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Repositories.Core;
using System.Collections.Generic;

namespace LibraryManager.Domain.Services.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IList<Book> GetAll();
        Book GetAuthorById(int id);
    }
}
