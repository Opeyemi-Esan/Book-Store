using BookStore.Data;
using BookStore.Model;

namespace BookStore.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel book);

    }
}
