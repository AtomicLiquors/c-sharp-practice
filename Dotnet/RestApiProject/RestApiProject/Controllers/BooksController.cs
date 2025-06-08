using Microsoft.AspNetCore.Mvc;
using RestApiProject.Model;

namespace RestApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // 왜 static인가?
        // 그렇지 않으면 HTTP 요청이 새로 생길 때마다 초기화되기 때문이다.
        static private List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks() {
            return Ok(books);
        }


        [HttpGet("{id}")]
        public ActionResult<List<Book>> GetBookById(int id) {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(books);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook) {
            if (newBook == null)
                return BadRequest();

            books.Add(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        }

        //[HttpPut]
        //public {
        //    }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id) {
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book == null)
                return NotFound();

            books.Remove(book);
            return NoContent();
        }

    }
}
