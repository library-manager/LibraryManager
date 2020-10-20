using LibraryManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Repositories
{
    public interface IAuthorRepository
    {
        IList<Author> GetAll();
        Author GetAuthorById(int id);
    }
}
