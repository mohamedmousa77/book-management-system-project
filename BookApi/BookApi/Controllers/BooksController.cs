using BookApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
namespace BookApi.Controllers
{
    // https://localhost:7033/api/books
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private Book[] _book = new Book[]
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_book);
        }
    }
}
