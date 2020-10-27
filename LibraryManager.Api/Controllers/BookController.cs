using LibraryManager.Domain.Entities.Dtos;
using LibraryManager.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Api.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = bookService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = bookService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateBookDto book)
        {
            var result = bookService.Create(book);
            return Ok(result);
        }
    }
}
