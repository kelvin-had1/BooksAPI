using Microsoft.AspNetCore.Mvc;
using Services.Model;
using Services.Repositories;

namespace Services.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBooks(int id)
        {

            return await _bookRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBooks([FromBody] Book book)
        {
            var newBook = await _bookRepository.Create(book);

            return CreatedAtAction(nameof(GetBooks), new {id = newBook.Id}, newBook);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookToDelete = _bookRepository.Get(id);

            if(bookToDelete == null)
            {
                return NotFound();
                
            }
            await _bookRepository.Delete(id);

            return NoContent();


        }

        [HttpPut]
        public async Task<ActionResult> PutBooks(int id, [FromBody] Book book)
        {
            if(id != book.Id)
            {
                return BadRequest();
            }
            await _bookRepository.Update(book);

            return NoContent();
        }

    }
}
