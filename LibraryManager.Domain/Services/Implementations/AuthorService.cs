using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Repositories;
using LibraryManager.Domain.Services.Contracts;
using System.Collections.Generic;

namespace LibraryManager.Domain.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IList<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return authorRepository.GetAuthorById(id);
        }
    }
}
