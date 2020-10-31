using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Entities.Dtos;
using LibraryManager.Domain.Repositories.Core;
using System.Collections.Generic;

namespace LibraryManager.Domain.Services.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IList<GetAllBooksDto> GetAll();
        Book GetAuthorById(int id);
    }
}
