using LibraryManager.Domain.Entities;
using System.Collections.Generic;

namespace LibraryManager.Domain.Services.Contracts
{
    public interface IAuthorService
    {
        IList<Author> GetAll();
        Author GetById(int id);
    }
}
