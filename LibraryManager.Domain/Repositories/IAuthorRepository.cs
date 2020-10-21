using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Repositories.Core;
using System.Collections.Generic;

namespace LibraryManager.Domain.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IList<Author> GetAll();
        Author GetAuthorById(int id);
    }
}
