using BookApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace BookApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{Id = 1, Author = "Raginee", Title = "Book 1"},
            new Book{Id = 2, Author = "Gunjan", Title = "Book 2" },
            new Book{Id = 3, Author = "Neha", Title = "Book 3"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }

    }
}
