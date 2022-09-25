using Microsoft.EntityFrameworkCore;
using Services.Model;

namespace Services.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;

        }

        async Task<Book> IBookRepository.Create(Book book)
        {
            _context.Books.Add(book);

            await _context.SaveChangesAsync();
            
            return book;
            
        }

        async Task IBookRepository.Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();


        }

        async Task<IEnumerable<Book>> IBookRepository.Get()
        {
            return await _context.Books.ToListAsync();
        }

        async Task<Book> IBookRepository.Get(int id)
        {
            return await _context.Books.FindAsync(id);
    }

        async Task IBookRepository.Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
