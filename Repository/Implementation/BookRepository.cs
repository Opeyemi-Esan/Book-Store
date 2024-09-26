using BookStore.Data;
using BookStore.Model;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        public BookRepository(BookStoreContext context) 
        {
            _context = context;
        }

        //public BookStoreContext Context { get; }

        public async Task<int> AddBookAsync(BookModel book)
        {
            var books = new Book()
            {
                Title = book.Title,
                Description = book.Description
            };

            _context.Books.Add(books);
            await _context.SaveChangesAsync();
            return books.Id;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var records = await _context.Books.ToListAsync();

            return records;
        }

        public async Task<Book> GetBookByIdAsync(int bookId)
        {
            var records = await _context.Books.Where(x => x.Id == bookId).FirstOrDefaultAsync();

            return records;
        }
    }
}
