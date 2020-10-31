using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Entities.Dtos;
using LibraryManager.Domain.Services.Contracts;
using System.Collections.Generic;

namespace LibraryManager.Domain.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IList<GetAllBooksDto> GetAll()
        {
            return bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return bookRepository.GetAuthorById(id);
        }

        public Book Create(CreateBookDto createBookDto)
        {
            var book = new Book(createBookDto.Name,
                                createBookDto.AuthorId,
                                createBookDto.Summary,
                                createBookDto.ImageUrl);

            bookRepository.Insert(book);
            return book;
        }
    }
}
