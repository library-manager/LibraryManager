using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Api.Controllers
{    
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = authorService.GetAll();
            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var result = authorService.GetById(id);
        //    return Ok(result);
        //}
    }
}
